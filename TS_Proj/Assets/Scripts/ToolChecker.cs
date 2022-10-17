using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolChecker : MonoBehaviour
{
   [SerializeField] private ToolsSO tools;

   private void Update()
   {
    Activation();
   }

   private void Activation()
   {
    if(tools.areScissorsSelected)
    {
        tools.isNeedleSelected = false;
    } else if(tools.isNeedleSelected)
    {
        tools.areScissorsSelected = false;
    }
   }

   
}
