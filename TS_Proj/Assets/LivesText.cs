using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesText : MonoBehaviour
{
    [SerializeField] private LifeSO lSO;

    public Text textBox;

    void Update()
    {
        textBox.text = ("Lives: " + lSO.lives);

        if(lSO.lives <= 0)
        {
            SceneManager.LoadScene("FailScene");
        }
    }
 
}
