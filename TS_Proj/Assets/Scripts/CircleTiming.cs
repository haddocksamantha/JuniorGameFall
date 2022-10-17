using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleTiming : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    
    public Material circleMat;

    private bool yay = false;

    private Color circleColor;
   

    private float intensity;

   
    private void Update()
    {
         if(Input.GetMouseButtonDown(0))
        {
            if(tools.isNeedleSelected== true)
            {
                StartCoroutine(CircleTimer());
            }
        }
    }

    IEnumerator CircleTimer(float runTime = 1f)
    {
        while(tools.isNeedleSelected == true)
        {
            yay = true;
            TurnColor("Green");
            Debug.Log("green");
            yield return new WaitForSeconds(runTime);
            yay = false;
            TurnColor("Red");
            Debug.Log("red");
        }
    }

    

    private void TurnColor(string thisColor)
    {
        switch(thisColor)
        {
            case "Green":
                circleColor = Color.green;
                intensity = 5.0f;
                circleMat.SetColor("_EmissionColor", circleColor * intensity);
                break;
            case "Red":
                circleColor = Color.red;
                intensity = 5.0f;
                circleMat.SetColor("_EmissionColor", circleColor * intensity);
                break;   
        }

    }

   
}
