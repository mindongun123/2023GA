using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bullet : MonoBehaviour
{
    public Sprite[] spriteBullet;
    public SpriteRenderer spriteRenderer;
    public float[] _velocity;
    public int _idSprite;
    private void Start()
    {
        // _idSprite = Random.Range(0, 3);
        spriteRenderer.sprite = spriteBullet[_idSprite];
        transform.DOMoveY(transform.position.y + 20, _velocity[_idSprite]).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complete);
    }
    public void Complete()
    {
        transform.DOKill();
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemystart"))
        {
            transform.DOKill();
            Destroy(gameObject);

            // Audio Target
            AudioController.instance.PlayAudioTarget();
        }
        if (other.gameObject.CompareTag("enemycross"))
        {
            transform.DOKill();
            Destroy(gameObject);
            // Audio Target
            AudioController.instance.PlayAudioTarget();
        }
        if (other.gameObject.CompareTag("enemybody"))
        {
            transform.DOKill();
            Destroy(gameObject);
            // Audio Target
            AudioController.instance.PlayAudioTarget();
        }
        if (other.gameObject.CompareTag("enemyrandom"))
        {
            transform.DOKill();
            Destroy(gameObject);
            // Audio Target
            AudioController.instance.PlayAudioTarget();
        }
        if (other.gameObject.CompareTag("egg"))
        {
            transform.DOKill();
            Destroy(gameObject);

            // Audio Hit Egg
            AudioController.instance.PlayAudioHitEgg();

        }
    }
}
