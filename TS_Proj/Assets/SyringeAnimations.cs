using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeAnimations : MonoBehaviour
{
    [SerializeField] private Animator syAnim;

  

    private void Start()
    {
        StartCoroutine(PlayFlashAnim(0.5f));
    }

    IEnumerator PlayFlashAnim(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        syAnim.Play("SyFlash", 0, 0.0f);
    }

}
