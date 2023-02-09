using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DTEnemy7 : DTEnemy
{
    public static DTEnemy7 instance;
    private void Awake()
    {
        instance = this;
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("bulletdtplayer"))
        {
            Game1Controller.instance.CreateDT7();
            Destroy(gameObject);

        }
    }
}
