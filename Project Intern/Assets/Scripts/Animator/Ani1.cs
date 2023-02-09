using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Ani1 : MonoBehaviour
{
    float y1, y2;
    private void Start()
    {
        y1 = transform.position.y - Random.Range(0.25f, 0.5f);
        y2 = transform.position.y + Random.Range(0.25f, 0.5f);
        Complete2();
    }
    public void Complete2()
    {
        transform.DOMoveY(y1, Random.Range(0.8f, 2)).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complete1);
    }
    public void Complete1()
    {
        transform.DOMoveY(y2, Random.Range(0.8f, 2)).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complete2);
    }
}
