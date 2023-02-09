using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Game1Controller : MonoBehaviour
{
    public static Game1Controller instance;

    [Header("Create DT Enemy")]
    public CreateDT[] CreateDTEnemyPrefabs;

    [Range(0, 10)]
    public float _timeDelayCreate;

    [Header("Score")]
    public int _scoreGame1;
    public int _scoreGame1Max;

    [Header("Health")]
    public int _hpDTPlayerGame1;

    [Header("End Start")]
    public GameObject[] ViewWallPrefabs;
    public GameObject PanelEndStart;
    public bool[] _locationNoStart;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        // Tao ra Cac Object o cac vi tri khac nhau 
        StartContinue();
    }
    
    public void StartContinue()
    {
        int _startGame1;
        for (int i = 0; i < 8; i++)
        {
            _startGame1 = Random.Range(0, 2);
            if (_startGame1 == 1 && _locationNoStart[i] == false)
            {
                _locationNoStart[i] = true;
                Instantiate(CreateDTEnemyPrefabs[i].DTEnemyPrefabs, CreateDTEnemyPrefabs[i].LocationCreateDTEnemy.position, transform.rotation);
            }
        }
        int _timeEndStart = Random.Range(50, 75);
        DOVirtual.DelayedCall(_timeEndStart + 4, StartEnd);
        DOVirtual.DelayedCall(_timeEndStart, On);
    }
    int _viewPanel;
    public void On()
    {
        _viewPanel = _viewPanel + 1;
        if (_viewPanel < 8)
        {
            if (_viewPanel % 2 == 0)
            {
                PanelEndStart.SetActive(true);
            }
            else
            {
                PanelEndStart.SetActive(false);
            }
            DOVirtual.DelayedCall(0.5f, On);
        }
    }

    public void StartEnd()
    {
        for (int i = 0; i < ViewWallPrefabs.Length; i++)
        {
            ViewWallPrefabs[i].SetActive(false);
        }
        for (int i = 0; i < 8; i++)
        {
            if (_locationNoStart[i] == false)
            {
                Instantiate(CreateDTEnemyPrefabs[i].DTEnemyPrefabs, CreateDTEnemyPrefabs[i].LocationCreateDTEnemy.position, transform.rotation);
            }
        }
    }

    #region CreateDT1
    public void CreateDT1()
    {
        DOVirtual.DelayedCall(_timeDelayCreate, CreateDTEnemy1);
    }
    public void CreateDTEnemy1()
    {
        Instantiate(CreateDTEnemyPrefabs[0].DTEnemyPrefabs, CreateDTEnemyPrefabs[0].LocationCreateDTEnemy.position, transform.rotation);
    }
    #endregion

    #region CreateDT2    
    public void CreateDT2()
    {
        DOVirtual.DelayedCall(_timeDelayCreate, CreateDTEnemy2);
    }
    public void CreateDTEnemy2()
    {
        Instantiate(CreateDTEnemyPrefabs[1].DTEnemyPrefabs, CreateDTEnemyPrefabs[1].LocationCreateDTEnemy.position, transform.rotation);
    }
    #endregion

    #region CreateDT3
    public void CreateDT3()
    {
        DOVirtual.DelayedCall(_timeDelayCreate, CreateDTEnemy3);
    }
    public void CreateDTEnemy3()
    {
        Instantiate(CreateDTEnemyPrefabs[2].DTEnemyPrefabs, CreateDTEnemyPrefabs[2].LocationCreateDTEnemy.position, transform.rotation);
    }
    #endregion

    #region CreateDT4 
    public void CreateDT4()
    {
        DOVirtual.DelayedCall(_timeDelayCreate, CreateDTEnemy4);
    }
    public void CreateDTEnemy4()
    {
        Instantiate(CreateDTEnemyPrefabs[3].DTEnemyPrefabs, CreateDTEnemyPrefabs[3].LocationCreateDTEnemy.position, transform.rotation);
    }
    #endregion

    #region CreateDT5 

    public void CreateDT5()
    {
        DOVirtual.DelayedCall(_timeDelayCreate, CreateDTEnemy5);
    }
    public void CreateDTEnemy5()
    {
        Instantiate(CreateDTEnemyPrefabs[4].DTEnemyPrefabs, CreateDTEnemyPrefabs[4].LocationCreateDTEnemy.position, transform.rotation);
    }

    #endregion

    #region CreateDT6 

    public void CreateDT6()
    {
        DOVirtual.DelayedCall(_timeDelayCreate, CreateDTEnemy6);
    }
    public void CreateDTEnemy6()
    {
        Instantiate(CreateDTEnemyPrefabs[5].DTEnemyPrefabs, CreateDTEnemyPrefabs[5].LocationCreateDTEnemy.position, transform.rotation);
    }
    #endregion

    #region CreateDT7

    public void CreateDT7()
    {
        DOVirtual.DelayedCall(_timeDelayCreate, CreateDTEnemy7);
    }
    public void CreateDTEnemy7()
    {
        Instantiate(CreateDTEnemyPrefabs[6].DTEnemyPrefabs, CreateDTEnemyPrefabs[6].LocationCreateDTEnemy.position, transform.rotation);
    }
    #endregion

    #region CreateDT8

    public void CreateDT8()
    {
        DOVirtual.DelayedCall(_timeDelayCreate, CreateDTEnemy8);
    }
    public void CreateDTEnemy8()
    {
        Instantiate(CreateDTEnemyPrefabs[7].DTEnemyPrefabs, CreateDTEnemyPrefabs[7].LocationCreateDTEnemy.position, transform.rotation);
    }

    #endregion

}