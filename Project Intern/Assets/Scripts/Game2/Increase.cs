using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Increase : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveY(transform.position.y - 30, 4).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complete);
    }

    public void Complete()
    {
        transform.DOKill();
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("spaceship"))
        {
            Complete();
        }
    }
}
