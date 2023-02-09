using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using TMPro;
public class GameOverGame2 : GameOverController
{
    private void Start()
    {
        // UI Score Playing Game - UI diem cua game khi dang choi game
        UI_ScorePlayingGame.SetActive(false); // (Image Score)
        //

        UI_t_Score.text = GameController.instance._score.ToString();
        DOVirtual.DelayedCall(6, ViewUI);
        if (GameController.instance._score > GameController.instance._scoreMax)
        {
            GameController.instance._scoreMax = GameController.instance._score;
            UI_HighScore.SetActive(true);
        }
        else
        {
            UI_Score.SetActive(true);
        }
    }

    public void UI_b_Home()
    {
        SceneManager.LoadScene("HomeGame");
    }
    public void UI_b_Continue()
    {
        SceneManager.LoadScene("Game2");
        Time.timeScale = 1;
    }
}
