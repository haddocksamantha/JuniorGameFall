using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleClicked : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    [SerializeField] private LayerMask layerMask;
    
    public GameObject glowObj;

    private GameObject glowClone;

    private int numOfClicks;

    //private float pinkIntensity = 5f;

    private void Start()
    {
      tools.nMaxGlow = 0;
      tools.isNeedleSelected = false;
      tools.sewing = false;
    }

 
    private void PrintName (GameObject needleObj)
    {
      print(needleObj.name);
    }

    private void Update()
    {
      CheckForClick();
    }
  
    private void CheckForClick()
    {
      if(Input.GetMouseButtonDown(0))
      {
        NeedleActive();
        RayClick();
      }
    }

  private void NeedleActive()
  {
    if(tools.isNeedleSelected == false)
    {
      DisableGlow();
    }
  }

  private void Glow()
  {
    if(tools.cuttingComplete == true)
    {
        if(tools.nMaxGlow == 0)
        {
          glowClone = Instantiate(glowObj,transform.position,transform.rotation);
          tools.nMaxGlow++;
          tools.sewing = true;
        }
    }
  
  }

  private void DisableGlow()
  {
   Destroy(glowClone);
   tools.sewing = false;
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
             tools.isNeedleSelected = true;

             Glow();
             OtherOff();
        }
    }
  }

  private void OtherOff()
  {
    tools.areScissorsSelected = false; 
    tools.sMaxGlow = 0;

    tools.isSyringeSelected = false;
    tools.syMaxGlow = 0;

    tools.isBandaidSelected = false;
    tools.bMaxGlow = 0;
  }

}
