using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public static AudioController instance;

    [Header("Audio Playing Game")]
    public AudioSource auSourcePlayingGame;

    [Header("Audio Shooting Bullet")]
    public AudioSource auSourceShootingBullet;

    [Header("Audio Target")]
    public AudioSource auSourceTarget;

    [Header("Audio Game Over")]
    public AudioSource auSourceGameOver;

    [Header("Audio Hit Spaceship")]
    public AudioSource auSourceHitSpaceship;
    [Header("Audio Hit Egg")]
    public AudioSource auSourceHitEgg;
    [Header("Audio Increase")]
    public AudioSource auSourceIncrease;

    [Header("Audio Volume Game")]
    [Range(0, 1)]
    public float _audioVolumeGame;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        auSourcePlayingGame.Play();
        auSourcePlayingGame.loop = true;
    }

    public void PlayAudioGameOver()
    {
        auSourcePlayingGame.Pause();
        auSourceGameOver.Play();
    }
    public void PlayAudioShootingBullet()
    {
        auSourceShootingBullet.Play();
        auSourceShootingBullet.loop = false;
    }

    public void PlayAudioTarget()
    {
        auSourceTarget.Play();
        auSourceShootingBullet.loop = false;
    }

    public void PlayAudioHitSpaceship()
    {
        auSourceHitSpaceship.Play();
        auSourceHitSpaceship.loop = false;
    }
    public void PlayAudioHitEgg()
    {
        auSourceHitEgg.Play();
        auSourceHitEgg.loop = false;
    }

    public void PlayAudioIncrease()
    {
        auSourceIncrease.Play();
        auSourceIncrease.loop = false;
    }

    private void Update()
    {
        auSourcePlayingGame.volume = _audioVolumeGame;
        auSourceShootingBullet.volume = _audioVolumeGame;
        auSourceGameOver.volume = _audioVolumeGame;
        auSourceHitSpaceship.volume = _audioVolumeGame;
        auSourceHitEgg.volume = _audioVolumeGame;
        auSourceIncrease.volume = _audioVolumeGame;
        auSourceTarget.volume = _audioVolumeGame;
    }
}
