using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DTEnemy8 : DTEnemy
{
    public static DTEnemy8 instance;
    private void Awake()
    {
        instance = this;
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("bulletdtplayer"))
        {
            Game1Controller.instance.CreateDT8();
            Destroy(gameObject);

        }
    }

}
