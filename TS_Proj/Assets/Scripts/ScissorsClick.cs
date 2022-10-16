using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsClick : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    
    public Material scissorMat;

    private int numOfClicks;


    private void Awake()
    {
        tools.areScissorsSelected = false;
    }

    private void Start()
    {
        numOfClicks = 0;
    }

 
    private void PrintName (GameObject scissorsObj)
    {
        print(scissorsObj.name);
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

  private void ScissorsActive()
  {
    tools.areScissorsSelected = true;

    if(tools.areScissorsSelected == true)
    {
        Glow();
    } else if(tools.areScissorsSelected == false)
    {
        DisableGlow();
    }else
    {
        tools.areScissorsSelected = false;
    }
  }

  private void Glow()
  {
    scissorMat.EnableKeyword ("_EMISSION");
  }

  private void DisableGlow()
  {
    scissorMat.DisableKeyword ("_EMISSION");
  }

  private void RayClick()
  {
    RaycastHit clicked;
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    
    if (Physics.Raycast(ray, out clicked, 100.0f)) 
    {
        if(clicked.transform != null)
        {
            if(numOfClicks < 1)
            {
                numOfClicks++;
                PrintName(clicked.transform.gameObject);
                ScissorsActive();
            }
        }

    }
  }



}
