using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsClick : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    [SerializeField] private LayerMask layerMask;
    
    public GameObject glowObj;

    private GameObject glowClone;

    private int numOfClicks;

    //private float pinkIntensity = 5f;

    private void Start()
    {
      tools.sMaxGlow = 0;
      tools.areScissorsSelected = false;
    }

 
    private void PrintName (GameObject scissorsObj)
    {
        print(scissorsObj.name);
    }

    private void Update()
    {
      CheckForClick();
      ScissorsActive();
    }
  
    private void CheckForClick()
    {
      if(Input.GetMouseButtonDown(0))
      {
        //ScissorsActive();
        RayClick();
      }
    }

  private void ScissorsActive()
  {
    if(tools.areScissorsSelected == false)
    {
      //Debug.Log("scissors check run");
      DisableGlow();
    }
  }

  private void Glow()
  {
    if(tools.sMaxGlow == 0)
    {
      glowClone = Instantiate(glowObj,transform.position,transform.rotation);
      tools.sMaxGlow++;
    }
  }

  private void DisableGlow()
  {
    
    Destroy(glowClone);
    //Debug.Log("SCISSORS DISABLED, " + tools.sMaxGlow + ", " + tools.areScissorsSelected);
  }

  private void RayClick()
  {
    RaycastHit clicked;
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    
    if (Physics.Raycast(ray, out clicked, 100.0f, layerMask)) 
    {
        if(clicked.transform != null)
        {
             PrintName(clicked.transform.gameObject);
             tools.areScissorsSelected = true;
             Glow();
             OtherOff();
        }
    }
  }

  private void OtherOff()
  {
    tools.isNeedleSelected = false; 
    tools.nMaxGlow = 0;

    tools.isSyringeSelected = false;
    tools.syMaxGlow = 0;
  }

}
