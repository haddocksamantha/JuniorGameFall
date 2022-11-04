using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeAnimations : MonoBehaviour
{
    [SerializeField] private Animator syAnim;
    [SerializeField] private ToolsSO tools;
    [SerializeField] private GameObject greenGlow;


    private void Start()
    {
        StartCoroutine(PlayFlashAnim(0.7f));
    }

    IEnumerator PlayFlashAnim(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        syAnim.Play("SyFlash", 0, 0.0f);
    }

    private void OnMouseDown()
    {
        if(tools.injecting == true)
        {
            greenGlow.SetActive(false);
        }
    }

   


}
