using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartTrigger : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;

    void Start()
    {
        tools.heartAdded = false;
    }

   void OnTriggerEnter(Collider other)
   {
     if(other.tag == "newHeart")
     {
        tools.heartAdded = true;
     }
   }
}
