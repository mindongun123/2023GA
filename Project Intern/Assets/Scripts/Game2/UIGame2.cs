using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIGame2 : UI
{
    public static UIGame2 instance;
    bool _checkAudioGameOver = false;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        sliderHealth.maxValue = 100;

        sliderHealth.value = GameController.instance._hpSpaceship;
        UI_t_Score.text = GameController.instance._score.ToString();


        if (sliderHealth.value <= 0)
        {
            // Audio Game Over
            if (_checkAudioGameOver == false)
            {
                // AudioController.instance.PlayAudioGameOver();
                _checkAudioGameOver = true;
            }
            //
            UI_gameover.SetActive(true);
            resumeStatus.SetActive(false);
        }

        // Image Sprite Status Button Resume
        imageRendererStatusResume.sprite = spriteStatusResume[_idStatusResume];

        // Audio Game
        VolumeGame();
    }

    public void VolumeGame()
    {
        sliderVolumeGame.maxValue = 1;
        sliderVolumeGame.minValue = 0;
        AudioController.instance._audioVolumeGame = sliderVolumeGame.value;
    }
}
