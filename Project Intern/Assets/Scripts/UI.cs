using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UI : MonoBehaviour
{

    [Header("Score")]
    public TextMeshProUGUI UI_t_Score;

    [Header("Health")]
    public Slider sliderHealth;

    [Header("Game Over")]
    public GameObject UI_gameover;

    [Header("Resume Status")]
    public GameObject resumeStatus;
    public Sprite[] spriteStatusResume;
    public Image imageRendererStatusResume;
    public int _idStatusResume;
    public bool _checkClickButtonResume;

    [Header("UI Mandates")]
    public GameObject UI_b_madates;

    [Header("UI Volume Game")]
    public Slider sliderVolumeGame;

    public void UI_b_ResumeStatusClick()
    {
        if (_idStatusResume == 0)
        {
            _idStatusResume = 1;
            _checkClickButtonResume = true;
            UI_b_madates.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            _checkClickButtonResume = false;
            UI_b_madates.SetActive(false);
            _idStatusResume = 0;
        }
    }

}
