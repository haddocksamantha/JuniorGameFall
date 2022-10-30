using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Vector3SO : ScriptableObject
{
  
  //use to randomize circle on syringe's injecting script 

  public Vector3[] circleLocations =  { 
    new Vector3(-0.0659999996f,0.004196758f,0.00789999962f),  
    new Vector3(0.0458999984f,0.004196758f,0.134399995f),  
    new Vector3(-0.0386000015f,0.004196758f,0.0846000016f),
    new Vector3(0.0366000012f,0.004196758f,0.0359000005f),
    new Vector3(0.0170000009f,0.004196758f,-0.0593999997f),
    new Vector3(-0.0763999969f,0.004196758f,0.223000005f),
    new Vector3(0.100000001f,0.004196758f,0.284000009f),
    new Vector3(-0.162f,0.004196758f,0.0529999994f)
  };
}
