using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sewing : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    [SerializeField] private Animator circleCtrl1;
    [SerializeField] private Animator circleCtrl2;
    [SerializeField] private Animator circleCtrl3;
    [SerializeField] private Animator teddyAnim;
    [SerializeField] private GameObject needleObj;
    [SerializeField] private LayerMask layerMask;

    private bool[] clickable = {false, false, false};
    private Animation circleAnim1;
    private Animation circleAnim2;
    private Animation circleAnim3;
    private Color circleColor;
    private float intensity;

    public GameObject circleGroup;
    public GameObject circle1;
    public GameObject circle2;
    public GameObject circle3;
    public Material circleMat;

   
    private void Awake()
    {
        circleGroup.SetActive(false);
        tools.sewing = false;
    }

    private void Start()
    {
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(false);

        clickable[0] = false;
        clickable[1] = false;
        clickable[2] = false;

        tools.sewingSteps[0] = false;
        tools.sewingSteps[1] = false;
        tools.sewingSteps[2] = false;

    }

    private void Update()
    {
        if(tools.sewing == true)
        {
            circleGroup.SetActive(true);

            if(Input.GetMouseButtonDown(0))
            {
                if(tools.sewingSteps[0] == false)
                {
                    circle1.SetActive(true);
                    PlayCircle1();
                }
            }
        }
    }

    private void PlayCircle1()
    {
        Debug.Log("circle played");
        circleCtrl1.Play("Circle01", 0, 0.0f);
        StartCoroutine(Circle1Timer());
    }


    IEnumerator Circle1Timer()
    {
        if(tools.sewingSteps[0] == false)
        {
            float redTime = 0.83333333333333f;
            float greenTime = 0.3333333333333f;

                TurnColor("Red");
            yield return new WaitForSeconds(redTime);
                TurnColor("Green");
                clickable[0] = true;
            yield return new WaitForSeconds(greenTime);
                TurnColor("Red");
            yield return new WaitForSeconds(redTime);
            StartCoroutine(Circle1Timer());

        }
    }

    void OnMouseDown()
    {
        RayClick();
    }

    private void RayClick()
    {
        RaycastHit clicked;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    
        if (Physics.Raycast(ray, out clicked, 100.0f, layerMask)) 
        {
            if(clicked.transform != null)
            {
                Clicking();
            }
        }
    }

    private void Clicking()
    {
        
        if (clickable[0] == true)
        {
            tools.sewingSteps[0] = true;
            Debug.Log("first stitch");
            circle1.SetActive(false);
        }else if(clickable[0] == false)
        {
            //subtract life
            circle1.SetActive(false);
            circle1.SetActive(true);
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
