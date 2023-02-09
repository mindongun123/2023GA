using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverController : MonoBehaviour
{
    [Header("UI Mandates")]
    public GameObject UI_b_madates;
    [Header("UI Score")]
    public TextMeshProUGUI UI_t_Score;

    [Header("Status Game Over")]
    public GameObject UI_HighScore;
    public GameObject UI_Score;

    [Header("UI Scrore Game Playing")]
    public GameObject UI_ScorePlayingGame;
    public void ViewUI()
    {
        UI_b_madates.SetActive(true);
    }

}
