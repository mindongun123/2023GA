using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DTEnemy : MonoBehaviour
{
    public GameObject PointShooting;
    public GameObject bulletEnemyPrefabs;

    public Transform[] target;
    public int _idTarget;
    // public float _timeDelayShootingBullet=3;
    private void Start()
    {
        // DOVirtual.DelayedCall(_timeDelayShootingBullet, Shooting);
        DOVirtual.DelayedCall(3, Shooting);
    }
    public void Shooting()
    {
        if (UIGame1.instance._checkClickButtonResume == false)
        {
            _idTarget = Random.Range(0, target.Length);
            Vector3 dis = target[_idTarget].position - transform.position;
            transform.right = dis.normalized;
            Instantiate(bulletEnemyPrefabs, PointShooting.transform.position, transform.rotation);
        }
        // DOVirtual.DelayedCall(_timeDelayShootingBullet, Shooting);
        DOVirtual.DelayedCall(_timeshooting, Shooting);

    }
    int _uptimeshooting;
    public float _timeshooting = 3;
    private void Update()
    {
        if (Game1Controller.instance._scoreGame1 - 100 > _uptimeshooting)
        {
            _uptimeshooting = Game1Controller.instance._scoreGame1;
            if (_timeshooting > 2)
            {
                _timeshooting = _timeshooting - 0.5f;
            }
        }
    }


}
