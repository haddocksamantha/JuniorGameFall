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
        SceneManager.LoadScene("GameStart");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadLevels()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void LoadWin()
    {
        SceneManager.LoadScene("WinScene");
    }
}
