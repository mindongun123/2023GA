using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteSpaceship;
    public int _idSpaceship;
    Vector3 move;

    [Header("Bullet")]
    public GameObject[] bulletPrefabs;
    public int _idBullet;


    private void Start()
    {
        spriteRenderer.sprite = spriteSpaceship[0];
    }
    private void Update()
    {
        if (_idSpaceship >= 4)
        {
            _idSpaceship = 4;
        }
        if (_idSpaceship <= 0)
        {
            _idSpaceship = 0;
        }
        spriteRenderer.sprite = spriteSpaceship[_idSpaceship];

        MoveSpaceship();
        ShootingBullet();
    }
    public void MoveSpaceship()
    {
        move = transform.position;
        move.y = move.y + Input.GetAxis("Vertical") * Time.deltaTime * 3;
        move.x = move.x + Input.GetAxis("Horizontal") * Time.deltaTime * 3;
        if (Mathf.Abs(move.x) <= 8 && Mathf.Abs(move.y) <= 4)
        {
            transform.position = move;
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("egg"))
        {
            _idBullet = _idBullet - 1;
            _idSpaceship = _idSpaceship - 1;
            AudioController.instance.PlayAudioHitSpaceship();
        }
        if (other.gameObject.CompareTag("enemystart"))
        {
            _idBullet = _idBullet - 1;
            _idSpaceship = _idSpaceship - 1;
            GameController.instance._hpSpaceship = GameController.instance._hpSpaceship - 15;
            AudioController.instance.PlayAudioHitSpaceship();
        }
        if (other.gameObject.CompareTag("enemyrandom"))
        {
            _idBullet = _idBullet - 1;
            _idSpaceship = _idSpaceship - 1;
            GameController.instance._hpSpaceship = GameController.instance._hpSpaceship - 20;
            AudioController.instance.PlayAudioHitSpaceship();

        }
        if (other.gameObject.CompareTag("enemybody"))
        {
            _idBullet = _idBullet - 1;
            _idSpaceship = _idSpaceship - 1;
            GameController.instance._hpSpaceship = GameController.instance._hpSpaceship - 25;
            AudioController.instance.PlayAudioHitSpaceship();

        }
        if (other.gameObject.CompareTag("enemycross"))
        {
            _idBullet = _idBullet - 1;
            _idSpaceship = _idSpaceship - 1;
            GameController.instance._hpSpaceship = GameController.instance._hpSpaceship - 35;
            AudioController.instance.PlayAudioHitSpaceship();

        }
        if (other.gameObject.CompareTag("increasespaceship"))
        {
            _idSpaceship = _idSpaceship + 1;
            AudioController.instance.PlayAudioIncrease();
        }
        if (other.gameObject.CompareTag("increasebullet"))
        {
            _idBullet = _idBullet + 1;
            AudioController.instance.PlayAudioIncrease();
        }
    }

    public void ShootingBullet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioController.instance.PlayAudioShootingBullet();
            if (_idBullet <= 0)
            {
                _idBullet = 0;
            }
            if (_idBullet >= 3)
            {
                _idBullet = 3;
            }
            if (UIGame2.instance._checkClickButtonResume == false)
            {
                GameObject newbullet = Instantiate(bulletPrefabs[_idBullet], transform.position + new Vector3(0, 1, 0), transform.rotation);
            }
        }
    }
}
