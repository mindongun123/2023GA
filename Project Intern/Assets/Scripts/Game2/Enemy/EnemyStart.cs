using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class EnemyStart : MonoBehaviour
{

    public GameObject EggPrefabs;
    public Sprite[] spriteStart;
    public SpriteRenderer spriteRenderer;
    public float _dis;
    public int _idSprite;

    private void Start()
    {
        // chon van toc , hinh anh
        spriteRenderer.sprite = spriteStart[_idSprite];
        transform.DOMoveY(transform.position.y - _dis, 5).SetEase(Ease.Linear).SetSpeedBased();


        // chon spawn ra trung

        DOVirtual.DelayedCall(Random.Range(2, 5), Shooting);
    }

    public void Shooting()
    {
        if (UIGame2.instance._checkClickButtonResume == false)
        {
            GameObject newEgg = Instantiate(EggPrefabs, transform.position, transform.rotation);
        }
        DOVirtual.DelayedCall(Random.Range(2, 5), Shooting);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("spaceship"))
        {
            GameController.instance._score = GameController.instance._score + 10;
            transform.DOKill();
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("bullet"))
        {
            GameController.instance._score = GameController.instance._score + 10;
            transform.DOKill();
            Destroy(gameObject);
        }
    }
}
