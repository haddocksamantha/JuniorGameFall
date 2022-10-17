using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleClicked : MonoBehaviour
{
     [SerializeField] private ToolsSO tools;
     [SerializeField] private LayerMask layerMask;
    
    public Material needleMat;

    private void Awake()
    {
        tools.isNeedleSelected = false;
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
         RayClick();
        }
    }

  private void NeedleActive()
  {
    tools.isNeedleSelected = true;

    if(tools.isNeedleSelected == true)
    {
        Glow();
    } else if(tools.isNeedleSelected == false)
    {
        DisableGlow();
    }
    else
    {
        tools.isNeedleSelected = false;
    }
  }

  private void Glow()
  {
    needleMat.EnableKeyword ("_EMISSION");
  }

  private void DisableGlow()
  {
    needleMat.DisableKeyword ("_EMISSION");
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
            NeedleActive();
        }

    }
  }

}
