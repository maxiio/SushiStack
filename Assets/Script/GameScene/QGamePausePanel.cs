﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QGamePausePanel : MonoBehaviour
{
    void OnEnable()
    {
        Time.timeScale = 0; //일시정지
        GameObject.FindWithTag("SoundManager").GetComponent<BGMScript>().PauseGameBGM();
    }

    public void ResumeButtonClicked()
    {
        GameObject.FindWithTag("SoundManager").GetComponent<BGMScript>().ButtonClickedSoundPlay();
        Time.timeScale = 1;
        GameObject.FindWithTag("SoundManager").GetComponent<BGMScript>().GameBGMPlay();
        gameObject.SetActive(false);
    }

    public void GoMainButtonClicked()
    {
        GameObject.FindWithTag("SoundManager").GetComponent<BGMScript>().ButtonClickedSoundPlay();
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");
    }

    public void RePlayClicked()
    {
        GameObject.FindWithTag("SoundManager").GetComponent<BGMScript>().ButtonClickedSoundPlay();
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
