using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BulletDTPlayer : MonoBehaviour
{
    public GameObject targetShooting;
    public float _velocityBullet;

    private void Start()
    {
        AudioGame1Controller.instance.PlayAuDTPlayerShooting();

        targetShooting = GameObject.FindGameObjectWithTag("targetshooting");
        transform.DOMove(targetShooting.transform.position, _velocityBullet).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complete);
    }



    public void Complete()
    {
        transform.DOKill();
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("bulletdtenemy"))
        {
            AudioGame1Controller.instance.PlayAuBulletCollierBullet();
            Complete();
        }
        if (other.gameObject.CompareTag("dtenemy"))
        {
            AudioGame1Controller.instance.PlayAuDTEnemyDied();
            Game1Controller.instance._scoreGame1 = Game1Controller.instance._scoreGame1 + 10;
            Complete();
        }
        if (other.gameObject.CompareTag("wall"))
        {
            Complete();
        }
    }
}
