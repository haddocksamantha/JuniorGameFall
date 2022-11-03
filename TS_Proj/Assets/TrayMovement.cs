using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayMovement : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    [SerializeField] private Animator trayAnim;
    [SerializeField] private GameObject heart;
    [SerializeField] private Animation trayIn;

    private bool trayInPlayed;

    private void Awake()
    {
        heart.SetActive(false);
    }

    private void Start()
    {
        trayInPlayed = false;
        StartCoroutine(WaitOnStart(10.5f));
        
    }

  /*   private void Update()
    {
      
    } */

    private void PlayTrayIn()
    {
        trayAnim.Play("TrayIn", 0, 0.0f);
        Debug.Log("tray in");
        trayInPlayed = true;
    }

    IEnumerator WaitOnStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        PlayTrayIn();
    }
}
