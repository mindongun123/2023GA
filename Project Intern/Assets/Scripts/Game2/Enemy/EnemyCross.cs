using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyCross : MonoBehaviour
{
    private void Start()
    {
        transform.DOMove(transform.position - new Vector3(30, -10, 0), Random.Range(3, 6)).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complete);
    }

    public void Complete()
    {
        transform.DOKill();
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("spaceship"))
        {
            GameController.instance._score = GameController.instance._score + 35;

            transform.DOKill();
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("bullet"))
        {
            GameController.instance._score = GameController.instance._score + 35;
            transform.DOKill();
            Destroy(gameObject);
        }
    }
}
