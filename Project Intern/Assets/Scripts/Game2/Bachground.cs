using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bachground : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveY(-10.6f, GameController.instance._velocityBachground).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complate1);
    }
    private void Complate1()
    {
        GameObject a = Instantiate(GameController.instance.BachgroundPrefabs, new Vector3(0, 20.5f, 0), transform.rotation);
        transform.DOMoveY(-20.6f, GameController.instance._velocityBachground).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complate2);
    }

    private void Complate2()
    {
        transform.DOKill();
        Destroy(gameObject);
    }

}
