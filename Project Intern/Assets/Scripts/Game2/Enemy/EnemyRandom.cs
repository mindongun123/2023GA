using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyRandom : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprite;


    public GameObject[] EggPrefabs;
    private void Start()
    {
        spriteRenderer.sprite = sprite[Random.Range(0, 4)];

        // di chuyen
        transform.DOMoveY(transform.position.y - 30f, Random.Range(2, 8)).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complete);

        // shooting
        DOVirtual.DelayedCall(Random.Range(3, 8), Shooting);
    }

    public void Shooting()
    {
        if (UIGame2.instance._checkClickButtonResume == false)
        {
            Instantiate(EggPrefabs[Random.Range(0, 5)], transform.position, transform.rotation);
        }
        DOVirtual.DelayedCall(Random.Range(2, 5), Shooting);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("spaceship"))
        {
            GameController.instance._score = GameController.instance._score + 20;
            transform.DOKill();
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("bullet"))
        {
            GameController.instance._score = GameController.instance._score + 25;
            transform.DOKill();
            Destroy(gameObject);
        }
    }
    public void Complete()
    {
        transform.DOKill();
        Destroy(gameObject);
    }
}
