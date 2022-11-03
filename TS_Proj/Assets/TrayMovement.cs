using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayMovement : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    [SerializeField] private TraySO tray;
    [SerializeField] private Animator trayAnim;
    [SerializeField] private GameObject heart;
    [SerializeField] private GameObject trayObj;
    [SerializeField] private GameObject brokenHeart;


    private void Awake()
    {
        heart.SetActive(false);
    }

    private void Update()
    {
        if(tray.brokenHeartAdded == true)
        {  
            //targetGameObject.transform.parent = desiredParentGameObject.transform;
            brokenHeart.transform.parent = trayObj.transform;
            PlayTrayOutandIn();
            StartCoroutine(ActivateHeart(1.5f));
            tray.brokenHeartAdded = false;
            
        }else if(tray.newHeartRemoved == true)
        {
            // play tray out
            PlayTrayOut();
            tray.newHeartRemoved = false;
        }

    }

    private void Start()
    {
        StartCoroutine(WaitOnStart(5.5f));
    }

    private void PlayTrayIn()
    {
        trayAnim.Play("TrayIn", 0, 0.0f);
        //Debug.Log("tray in");
    }

    private void PlayTrayOutandIn()
    {
        trayAnim.Play("TrayOutandIn", 0, 0.0f);
        //Debug.Log("out and in");
    }

    private void PlayTrayOut()
    {
       trayAnim.Play("TrayOut", 0, 0.0f);
       Debug.Log("tray out");
    }


    IEnumerator WaitOnStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        PlayTrayIn();
    }

    IEnumerator ActivateHeart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        brokenHeart.SetActive(false);
        heart.SetActive(true);
    }

  
}
