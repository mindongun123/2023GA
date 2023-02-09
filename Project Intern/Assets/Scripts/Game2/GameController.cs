using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    [Header("Bachground")]
    public GameObject BachgroundPrefabs;
    public float _velocityBachground;
    public int _chechScoreMax;

    [Header("Enemy Move Start")]
    public GameObject[] EnemyStart;


    [Header("Enemy Body Game")]
    public GameObject[] EnemyBodyPrefabs;
    int _idEnemyBodyGame;

    [Header("Random Enemy")]
    public GameObject EnemyRandomPrefabs;

    [Header("Enemy Cross")]
    public GameObject EnemyCrossPrefabs;

    [Header("Hp SpaceShip")]
    public int _hpSpaceship;

    [Header("Increase")]
    public GameObject[] IncreasePrefabs;

    [Header("Score")]
    public int _scoreMax;
    public int _score;



    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {

        // Start Game
        DOVirtual.DelayedCall(0, Complate0);

        // Body Game
        DOVirtual.DelayedCall(30, CompleteBody);

        // Random Enemy
        DOVirtual.DelayedCall(50, CompleteRandomEnemy);

        // Enemy Cross 
        DOVirtual.DelayedCall(35, CompleteEnemyCross);

        // Increase
        DOVirtual.DelayedCall(40- Random.Range(0, 10), CreateIncrease);
    }

    #region  Create Increase
    public void CreateIncrease()
    {
        Instantiate(IncreasePrefabs[Random.Range(0, 2)], new Vector3(Random.Range(-8, 8), 20, 0), transform.rotation);
        DOVirtual.DelayedCall(Random.Range(30, 50), CreateIncrease);
    }
    #endregion

    #region Start Game 
    public void Complate0()
    {
        EnemyStart[0].SetActive(true);
        DOVirtual.DelayedCall(15, Complate1);
    }

    public void Complate1()
    {
        EnemyStart[1].SetActive(true);
    }

    #endregion

    #region Body Game
    public void CompleteBody()
    {
        _idEnemyBodyGame = Random.Range(0, 2);
        for (int i = -2; i < 3; i++)
        {
            Instantiate(EnemyBodyPrefabs[_idEnemyBodyGame], new Vector3(0, 8, 0) - new Vector3(2.5f * i, 0, 0), transform.rotation);
        }
        DOVirtual.DelayedCall(Random.Range(25, 40), CompleteBody);
    }

    #endregion

    #region  Random Enemy

    public void CompleteRandomEnemy()
    {
        Instantiate(EnemyRandomPrefabs, new Vector3(Random.Range(-8, 8), 16, 0), transform.rotation);
        DOVirtual.DelayedCall(3, CompleteRandomEnemy);
    }
    #endregion

    #region  Enemy Cross
    public void CompleteEnemyCross()
    {
        for (int i = 0; i < Random.Range(3, 6); i++)
        {
            Instantiate(EnemyCrossPrefabs, new Vector3(15, Random.Range(-18, 0), 0), transform.rotation);
        }
        DOVirtual.DelayedCall(Random.Range(30, 60), CreateIncrease);
    }

    #endregion

    private void Update()
    {
        if ((_score - _chechScoreMax) >= 100)
        {
            _chechScoreMax = _score;
            _velocityBachground = _velocityBachground + 2;
        }
    }
}
