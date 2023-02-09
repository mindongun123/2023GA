using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Egg : MonoBehaviour
{

    public Sprite[] spriteEgg;
    public int[] _velocityEgg;


    public int _id;
    public SpriteRenderer spriteRenderer;


    private void Start()
    {
        spriteRenderer.sprite = spriteEgg[_id];
        transform.DOMoveY(transform.position.y - 20f, _velocityEgg[_id]).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complate);
    }

    public void Complate()
    {
        IsDestroy();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("spaceship"))
        {

            // AudioController.instance.TrungDan();
            if (_id == 0 || _id == 1)
            {
                GameController.instance._hpSpaceship = GameController.instance._hpSpaceship - 5;
            }
            if (_id == 2 || _id == 3)
            {
                GameController.instance._hpSpaceship = GameController.instance._hpSpaceship - 10;
            }
            if (_id == 4)
            {
                GameController.instance._hpSpaceship = GameController.instance._hpSpaceship - 15;
            }
            IsDestroy();
        }
        if (other.gameObject.CompareTag("bullet"))
        {
            IsDestroy();
        }
    }

    public void IsDestroy()
    {
        transform.DOKill();
        Destroy(gameObject);
    }
}
