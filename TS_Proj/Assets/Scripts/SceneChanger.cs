using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadStart()
    {
        SceneManager.LoadScene("LevelStart");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void LoadLevels()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void LoadWin()
    {
        SceneManager.LoadScene("WinScene");
    }

    public void LoadLose()
    {
        SceneManager.LoadScene("FailScene");
    }
}
