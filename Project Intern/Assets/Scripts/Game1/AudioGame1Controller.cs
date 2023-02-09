using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGame1Controller : MonoBehaviour
{
    public static AudioGame1Controller instance;

    private void Start()
    {
        auPlayingGame.Play();
        auPlayingGame.loop = true;
    }

    [Header("Start Audio Playing Game")]
    public AudioSource auPlayingGame;

    [Header("Game Over")]
    public AudioSource auGameOver;

    public void PlayAuGameOver()
    {
        auPlayingGame.Pause();
        auGameOver.Play();
        auGameOver.loop = true;
    }

    [Header("DT Enemy Died")]
    public AudioSource auDTEnemyDied;
    public void PlayAuDTEnemyDied()
    {
        auDTEnemyDied.Play();
        auGameOver.loop = false;

    }

    [Header("DT Player Died")]
    public AudioSource auDTPlayerDied;
    public void PlayAuDTPlayerDied()
    {
        auDTPlayerDied.Play();
        auGameOver.loop = false;

    }

    [Header("DT Player Shooting")]
    public AudioSource auDTPlayerShooting;
    public void PlayAuDTPlayerShooting()
    {
        auDTPlayerShooting.Play();
        auGameOver.loop = false;

    }

    [Header("DT Enemy Shooting")]
    public AudioSource auDTEnemyShooting;
    public void PlayAuDTEnemyShooting()
    {
        auDTEnemyShooting.Play();
        auGameOver.loop = false;

    }

    [Header("Bullet Collider")]
    public AudioSource auBulletCollierBullet;
    public void PlayAuBulletCollierBullet()
    {
        auBulletCollierBullet.Play();
        auGameOver.loop = false;

    }

    [Header("DT Player Run")]
    public AudioSource auDTPlayerRun;
    public void PlayAuDTPlayerRun()
    {
        auDTPlayerRun.Play();
        auGameOver.loop = true;
    }

    [Header("Volume Game1")]
    [Range(0, 1)]
    public float _volumeGame1;

    private void Awake()
    {
        instance = this;
    }

    private void Update() {
        auPlayingGame.volume = _volumeGame1;
        auGameOver.volume = _volumeGame1;
        auDTEnemyDied.volume = _volumeGame1;
        auDTEnemyDied.volume = _volumeGame1;
        auDTEnemyShooting.volume = _volumeGame1;
        auDTPlayerShooting.volume = _volumeGame1;
        auBulletCollierBullet.volume = _volumeGame1;
        auDTPlayerRun.volume = _volumeGame1;
    }


}
