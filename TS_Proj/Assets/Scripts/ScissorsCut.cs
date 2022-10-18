using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsCut : MonoBehaviour
{
  [SerializeField] private Animator teddyAnim;

  private Animation cutAnim1;
  private Animation cutAnim2;
  private Animation cutAnim3;

  private int numOfClicks;

  public GameObject scissors;

  void Start()
  {
    scissors = gameObject.GetComponent<GameObject>();
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
    teddyAnim.Play("Cut01", 0, 0.0f);
  }

  private void PlayAnim2()
  {
    teddyAnim.Play("Cut02", 0, 0.0f);
  }

  private void PlayAnim3()
  {
    teddyAnim.Play("Cut03", 0, 0.0f);
  }


}
