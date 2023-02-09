using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BulletEnemy3 : BulletEnemy
{
   
    private void Start()
    {
        AudioGame1Controller.instance.PlayAuDTEnemyShooting();
        Vector3 dis = DTEnemy3.instance.target[DTEnemy3.instance._idTarget].position - transform.position;
        transform.right = dis.normalized;
        transform.DOMove(DTEnemy3.instance.target[DTEnemy3.instance._idTarget].position, _velocity).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complete);
    }
}
