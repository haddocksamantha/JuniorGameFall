using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeClick : MonoBehaviour
{
  //Used by "Injecting.cs" Script

      [SerializeField] private ToolsSO tools;
      [SerializeField] private LifeSO lSO;
    [SerializeField] private LayerMask layerMask;
    
    public GameObject glowObj;

    private GameObject glowClone;

    private int numOfClicks;

   

    private void Start()
    {
      tools.syMaxGlow = 0;
      tools.isSyringeSelected = false;
    }

 
    private void PrintName (GameObject syringeObj)
    {
      print(syringeObj.name);
    }

    private void Update()
    {
      CheckForClick();
      SyringeActive();
    }
  
    private void CheckForClick()
    {
      if(Input.GetMouseButtonDown(0))
      {
        RayClick();
      }
    }

  private void SyringeActive()
  {
    if(tools.isSyringeSelected == false)
    {
      DisableGlow();
    }
  }

  private void Glow()
  {
    if(tools.syMaxGlow == 0)
    {
      tools.injecting = true;
      glowClone = Instantiate(glowObj,transform.position,transform.rotation);
      tools.syMaxGlow++;
    }
  }

  private void DisableGlow()
  {
   Destroy(glowClone);
   tools.injecting = false;
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
             tools.isSyringeSelected = true;
             Glow();
             OtherOff();
        }else
        {
          lSO.lives -= 1;
        }
    }
  }

  private void OtherOff()
  {
    tools.isNeedleSelected = false; 
    tools.nMaxGlow = 0;
    
    tools.areScissorsSelected = false;
    tools.sMaxGlow = 0;

    tools.isBandaidSelected = false;
    tools.bMaxGlow = 0;
  }
}
