using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleTiming : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;



    IEnumerator CircleTimer(float runTime = 21f)
    {
        while(tools.isNeedleSelected == true)
        {
            yield return new WaitForSeconds(runTime);
        }
        
    }
}
