using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyBody : MonoBehaviour
{

    public GameObject[] EggPrefabs;
    public Vector3[] Path1;
    public Vector3[] Path2;
    public Vector3[] Path3;
    public Vector3[] Path4;

    public List<Vector3[]> listVectorPath;
    int _idPath;

    private void Awake()
    {
        listVectorPath = new List<Vector3[]>();
    }
    private void Start()
    {

        listVectorPath.Add(Path1);
        listVectorPath.Add(Path2);
        listVectorPath.Add(Path3);
        listVectorPath.Add(Path4);
        transform.DOMoveY(transform.position.y - 5, 2).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complate);

        // Shooting Egg

        DOVirtual.DelayedCall(Random.Range(3, 6), Shooting);
    }

    private void Complate()
    {

        _idPath = Random.Range(0, 4);
        for (int i = 0; i < listVectorPath[_idPath].Length; i++)
        {
            listVectorPath[_idPath][i] = transform.position - listVectorPath[_idPath][i];
        }
        transform.DOPath(listVectorPath[_idPath], 2).SetEase(Ease.Linear).SetSpeedBased().SetLoops(-1);
    }

    public void Shooting()
    {
        if (UIGame2.instance._checkClickButtonResume == false)
        {
            GameObject newEgg = Instantiate(EggPrefabs[Random.Range(0, 6)], transform.position, transform.rotation);
        }
        DOVirtual.DelayedCall(Random.Range(3, 6), Shooting);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("spaceship"))
        {
            GameController.instance._score = GameController.instance._score + 15;
            transform.DOKill();
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("bullet"))
        {
            GameController.instance._score = GameController.instance._score + 15;
            transform.DOKill();
            Destroy(gameObject);

        }
    }

}
