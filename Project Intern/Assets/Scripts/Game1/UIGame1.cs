using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIGame1 : UI
{
    public static UIGame1 instance;
    bool _checkAudioGameOver = false;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        sliderHealth.maxValue = 100;
        sliderHealth.value = Game1Controller.instance._hpDTPlayerGame1;
        UI_t_Score.text = Game1Controller.instance._scoreGame1.ToString();


        if (sliderHealth.value <= 0)
        {
            // Audio Game Over
            if (_checkAudioGameOver == false)
            {
                // AudioController.instance.PlayAudioGameOver();
                _checkAudioGameOver = true;
            }
            
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
        AudioGame1Controller.instance._volumeGame1 = sliderVolumeGame.value;
    }
}
