using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;
using System;

public class DTPlayer : MonoBehaviour
{
    public GameObject pointShooting;
    public GameObject bulletDTPlayerPrefabs;
    public int _hp;

    public float _speed;

    public float _timeDelayShooting;

    private void Start()
    {
        DOVirtual.DelayedCall(_timeDelayShooting, Shooting);
    }

    int _upvelocity;

    private void Update()
    {
        if (Game1Controller.instance._scoreGame1 - 100 > _upvelocity)
        {
            _upvelocity = Game1Controller.instance._scoreGame1;
            if (_timeDelayShooting > 2)
            {
                _timeDelayShooting = _timeDelayShooting - 1;
            }
        }
        MoveDTPlayer();
    }
    public Vector2 inputVelocity;
    private void MoveDTPlayer()
    {
        Vector2 moveDTPlayer = transform.position;
        inputVelocity = new Vector2(Input.GetAxis("Horizontal") * Time.deltaTime * _speed, Input.GetAxis("Vertical") * Time.deltaTime * _speed);
        moveDTPlayer = moveDTPlayer + inputVelocity;
        DirectionDTPlayer(inputVelocity);
        transform.position = moveDTPlayer;

    }

    bool _checkx;

    public void DirectionDTPlayer(Vector2 inputVelocity)
    {
        if (inputVelocity.x > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (inputVelocity.x < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
        if (inputVelocity.y > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        if (inputVelocity.y < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, -90);
        }

        CheckAudioRun();
    }
    public bool _checkRun;

    private void CheckAudioRun()
    {
        if (inputVelocity != new Vector2(0, 0))
        {
            if (_checkRun == false)
            {
                _checkRun = true;
                // AudioGame1Controller.instance.PlayAuDTPlayerRun();
                AudioGame1Controller.instance.auDTPlayerRun.loop = true;
                AudioGame1Controller.instance.auDTPlayerRun.Play();

            }
        }
        else
        {
            _checkRun = false;
            AudioGame1Controller.instance.auDTPlayerRun.Pause();
        }
    }

    public void Shooting()
    {
        if (UIGame1.instance._checkClickButtonResume == false)
        {
            Instantiate(bulletDTPlayerPrefabs, pointShooting.transform.position, transform.rotation);
        }
        DOVirtual.DelayedCall(_timeDelayShooting, Shooting);

    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("bulletdtenemy"))
        {

            AudioGame1Controller.instance.PlayAuDTPlayerDied();
            Game1Controller.instance._hpDTPlayerGame1 = Game1Controller.instance._hpDTPlayerGame1 - 10;
        }
        if (other.gameObject.CompareTag("wall"))
        {
            inputVelocity = new Vector2(0, 0);
        }
    }

}
