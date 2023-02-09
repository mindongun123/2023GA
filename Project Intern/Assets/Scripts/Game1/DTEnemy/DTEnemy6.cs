using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DTEnemy6 : DTEnemy
{
    public static DTEnemy6 instance;
    private void Awake()
    {
        instance = this;
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("bulletdtplayer"))
        {
            Game1Controller.instance.CreateDT6();
            Destroy(gameObject);

        }
    }
}
