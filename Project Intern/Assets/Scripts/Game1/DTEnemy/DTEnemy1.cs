using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DTEnemy1 : DTEnemy
{
    public static DTEnemy1 instance;
    private void Awake()
    {
        instance = this;
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("bulletdtplayer"))
        {
            Game1Controller.instance.CreateDT1();
            Destroy(gameObject);
        }
    }
}
