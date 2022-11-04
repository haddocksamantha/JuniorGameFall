using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayTriggers : MonoBehaviour
{
    [SerializeField] private TraySO tray;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "brokenHeart")
        {
            tray.brokenHeartAdded = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "newHeart")
        {
            tray.newHeartRemoved = true;
        }
    }
  
    private void Start()
    {
        tray.brokenHeartAdded = false;
        tray.newHeartRemoved = false;
    }

   
}
