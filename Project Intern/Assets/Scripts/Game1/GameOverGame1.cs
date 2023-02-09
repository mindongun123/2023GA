using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class GameOverGame1 : GameOverController
{
    private void Start()
    {
        // UI Score Playing Game - UI diem cua game khi dang choi game
        UI_ScorePlayingGame.SetActive(false); // (Image Score)
        //
        UIGame1.instance._checkClickButtonResume = true;
        AudioGame1Controller.instance.PlayAuGameOver();

        UI_t_Score.text = Game1Controller.instance._scoreGame1.ToString();
        DOVirtual.DelayedCall(6, ViewUI);
        if (Game1Controller.instance._scoreGame1 > Game1Controller.instance._scoreGame1Max)
        {
            Game1Controller.instance._scoreGame1Max = Game1Controller.instance._scoreGame1;
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
        SceneManager.LoadScene("Game1");
        Time.timeScale = 1;
    }

}
