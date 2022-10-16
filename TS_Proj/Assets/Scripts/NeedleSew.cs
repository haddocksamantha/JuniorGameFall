using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleSew : MonoBehaviour
{
  [SerializeField] private Animator teddyAnim;

  public Animation sewAnim1;
  private Animation sewAnim2;
  private Animation sewAnim3;

  private int numOfClicks;

  public GameObject needle;

  

  void Start()
  {
    needle = gameObject.GetComponent<GameObject>();
    numOfClicks = 0;

  }

  private void Update()
  {
    CheckForClick();
  }

  private void CheckForClick()
  {
    if(Input.GetMouseButtonDown(0))
    {
      numOfClicks ++;
      if(numOfClicks == 1)
      {
        PlayAnim1(); 
      }else if(numOfClicks == 2)
      {
        PlayAnim2();
      }else if(numOfClicks == 3)
      {
        PlayAnim3();
      }else
      {
        Debug.Log("cuts complete");
      }
         
    }
  }

  private void PlayAnim1()
  {
    teddyAnim.Play("Sew01", 0, 0.0f);
  }

  private void PlayAnim2()
  {
    Debug.Log("Sew 2");
    /* teddyAnim.Play("Sew02", 0, 0.0f); */
  }

  private void PlayAnim3()
  {
    Debug.Log("Sew 3");
    /* teddyAnim.Play("Sew03", 0, 0.0f); */
  }

}
