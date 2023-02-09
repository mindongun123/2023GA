using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public AudioSource auSoureHome;
    public Slider sliderVolume;
    [Range(0, 1)]
    public float _volume;
    public void UI_b_GameShootingChicken()
    {
        SceneManager.LoadScene("Game2");
    }
    public void UI_b_GameDT()
    {
        SceneManager.LoadScene("Game1");
    }
    private void Start()
    {
        Time.timeScale = 1;
        auSoureHome.Play();
    }
    private void Update()
    {
        sliderVolume.maxValue = 1;
        sliderVolume.minValue = 0;
        _volume = sliderVolume.value;
        auSoureHome.loop = true;
        auSoureHome.volume = _volume;
    }

}
