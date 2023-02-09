using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BulletEnemy : MonoBehaviour
{
    public float _velocity;
    public void Complete()
    {
        transform.DOKill();
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("bulletdtplayer"))
        {
            Complete();
        }
        if (other.gameObject.CompareTag("dtplayer"))
        {
            Complete();
        }
    }
}
