using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Injecting : MonoBehaviour
{
   [SerializeField] private ToolsSO tools;

   private void Update()
   {
        if(tools.injecting == true)
        {
            Debug.Log("Injecting");
        }
   }
}
