using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnWoundEnter : MonoBehaviour
{
   public UnityEvent onWoundEnterEvent;

   private void OnTriggerEnter(Collider other)
   {
    onWoundEnterEvent.Invoke();
   }
}
