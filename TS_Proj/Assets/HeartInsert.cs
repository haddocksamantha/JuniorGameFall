using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartInsert : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    [SerializeField] private Rigidbody heartRB;

    private void Start()
    {
        tools.heartRemoved = false;
        tools.heartAdded = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Heart")
        {
            //freeze heart
            FreezeConstraints();
            tools.heartAdded = true;
        }
    }


    private void FreezeConstraints()
    {
        heartRB.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
        heartRB.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
        heartRB.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationX;
    }
 
}
