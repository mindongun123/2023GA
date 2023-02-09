using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BulletEnemy5 : BulletEnemy
{

    private void Start()
    {
        AudioGame1Controller.instance.PlayAuDTEnemyShooting();
        Vector3 dis = DTEnemy5.instance.target[DTEnemy5.instance._idTarget].position - transform.position;
        transform.right = dis.normalized;
        transform.DOMove(DTEnemy5.instance.target[DTEnemy5.instance._idTarget].position, _velocity).SetEase(Ease.Linear).SetSpeedBased().OnComplete(Complete);
    }
}
