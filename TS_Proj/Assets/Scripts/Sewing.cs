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
            Step1();
        }
    }

    private void Step1()
    {
        if(tools.sewingSteps[0] == false)
        {
            circle1.SetActive(true);
            PlayCircle1();
        }
    }
     
    private void PlayCircle1()
    {
        circleCtrl1.Play("Circle01", 0, 0.0f);
        StartCoroutine(Circle1Timer());
    }

    IEnumerator Circle1Timer()
    {
        while(tools.sewingSteps[0] == false)
        {
            float redTime = 0.5f;
            float greenTime = 0.2f;

                TurnColor("Red");
            yield return new WaitForSeconds(redTime);
                TurnColor("Green");
            yield return new WaitForSeconds(greenTime);
            StartCoroutine(Circle1Timer());
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
