using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandaidClick : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    [SerializeField] private LayerMask layerMask;
    
    public GameObject glowObj;

    private GameObject glowClone;

    private int numOfClicks;

    //private float pinkIntensity = 5f;

    private void Start()
    {
      tools.bMaxGlow = 0;
      tools.isBandaidSelected = false;
    }

 
    private void PrintName (GameObject bandaidObj)
    {
        print(bandaidObj.name);
    }

    private void Update()
    {
      CheckForClick();
      BandaidActive();
    }
  
    private void CheckForClick()
    {
      if(Input.GetMouseButtonDown(0))
      {
        RayClick();
      }
    }

  private void BandaidActive()
  {
    if(tools.isBandaidSelected == false)
    {
      DisableGlow();
    }
  }

  private void Glow()
  {
    if(tools.bMaxGlow == 0)
    {
      glowClone = Instantiate(glowObj,transform.position,transform.rotation);
      tools.bMaxGlow++;
    }
  }

  private void DisableGlow()
  {
   Destroy(glowClone);
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
             tools.isBandaidSelected = true;
             Glow();
             OtherOff();
        }
    }
  }

  private void OtherOff()
  {
    tools.isNeedleSelected = false; 
    tools.nMaxGlow = 0;
    
    tools.areScissorsSelected = false;
    tools.sMaxGlow = 0;

    tools.isSyringeSelected = false;
    tools.syMaxGlow = 0;
  }
}
