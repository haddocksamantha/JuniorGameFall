using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleTiming : MonoBehaviour
{
/*     [SerializeField] private ToolsSO tools;
    [SerializeField] private Animator circleAnim;
    [SerializeField] private LayerMask layerMask;

    private Animation circle1;
    private Animation circle2;
    private Animation circle3;
    
    public Material circleMat;

    private Color circleColor;

    private bool[] win = {false,false,false};
    private bool[] yay = {false,false,false};

    private float intensity;

    private void Start()
    {
        tools.sewing = false;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CheckIfActive();
            RayClick();
        }
        SewingTime();
    }

    IEnumerator CircleTimer(float runTime = 0.50f)
    {
        yay[1] = false;
        TurnColor("Red");
        Debug.Log("red");
            yield return new WaitForSeconds(runTime);
        yay[1] = true;
        TurnColor("Green");
        Debug.Log("green");
            yield return new WaitForSeconds(0.20f);
        StartCoroutine(CircleTimer());
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

    private void SewingTime()
    {
        while(tools.isNeedleSelected)
        {
            tools.sewing = true;
        }
    }

    private void CheckIfActive()
    {
        if(tools.sewing == true)
        {
            PlaySew1();
        }else if(win[0] == true)
        {
            PlaySew2();
        }else if(win[1] == true)
        {
            PlaySew3();
        }else if (win[2] == true)
        {
            Debug.Log("Sewing Complete;");
        }
    }

    private void PlaySew1()
    {
        //activate timing coroutine
        StartCoroutine(CircleTimer());
        circleAnim.Play("Circle01, 0, 0.0f");
        
        //teddyAnim.Play("Sew01", 0, 0.0f);
    }

    private void PlaySew2()

    {

    }

    private void PlaySew3()
    {

    }

    private void RayClick()
    {
        RaycastHit clicked;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    
        if (Physics.Raycast(ray, out clicked, 100.0f, layerMask)) 
        {
            if(clicked.transform != null)
            {
                Debug.Log("circle clicked");
            }
        }
    }

    

    */
}
