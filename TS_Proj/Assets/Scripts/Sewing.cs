using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sewing : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    [SerializeField] private CircleSO circle;
    [SerializeField] private LifeSO lSO;

    [SerializeField] private Animator circleCtrl1;
    [SerializeField] private Animator circleCtrl2;
    [SerializeField] private Animator circleCtrl3;
    [SerializeField] private Animator teddyAnim;

    [SerializeField] private GameObject needleObj;

    [SerializeField] private LayerMask layerMask;
    

    private bool[] clickable = {false, false, false};
    private bool[] played = {false, false, false};

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
        lSO.lives = 3;
    }

    private void Start()
    {
        tools.sewingComplete = false; 
        
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(false);

        clickable[0] = false;
        clickable[1] = false;
        clickable[2] = false;

        tools.sewingSteps[0] = false;
        tools.sewingSteps[1] = false;
        tools.sewingSteps[2] = false;

        played[0] = false;
        played[1] = false;
        played[2] = false;

    }

    private void Update()
    {
        if(tools.sewing == true)
        {
            circleGroup.SetActive(true);
            //circle1.SetActive(true);
                  
                Click();

                if(clickable[0] == false)
                { 
                    if(tools.sewingSteps[0] == false)
                    {
                         circle1.SetActive(true);
                        if(played[0] == false)
                        {
                                PlayCircle1();
                        }
                            
                    }
                }
                
            }
    }

    private void PlayCircle1()
    {
        if(clickable[0] == false)
        {
            
            //Debug.Log("circle played");
            circleCtrl1.Play("Circle01", 0, 0.0f);
            played[0] = true;
            StartCoroutine(Circle1Timer());
        }
    }


    IEnumerator Circle1Timer()
    {
        if(tools.sewingSteps[0] == false)
        {
            float redTime = 0.83333333333333f;
            float greenTime = 0.3333333333333f;

                TurnColor("Red");
                clickable[0] = false;
            yield return new WaitForSeconds(redTime);
                TurnColor("Green");
                clickable[0] = true;
            yield return new WaitForSeconds(greenTime);
                TurnColor("Red");
                clickable[0] = false;
            yield return new WaitForSeconds(redTime);
            StartCoroutine(Circle1Timer());

        }
    }

    IEnumerator Circle2Timer()
    {
        if(tools.sewingSteps[1] == false)
        {
            float redTime = 0.666666667f;
            float greenTime = 0.3333333333333f;

                TurnColor("Red");
                clickable[1] = false;
            yield return new WaitForSeconds(redTime);
                TurnColor("Green");
                clickable[1] = true;
            yield return new WaitForSeconds(greenTime);
                TurnColor("Red");
                clickable[1] = false;
            yield return new WaitForSeconds(redTime);
            StartCoroutine(Circle2Timer());
        }
    }

       IEnumerator Circle3Timer()
    {
        if(tools.sewingSteps[2] == false)
        {
            float redTime = 0.5f;
            float greenTime = 0.16666667f;

                TurnColor("Red");
                clickable[2] = false;
            yield return new WaitForSeconds(redTime);
                TurnColor("Green");
                clickable[2] = true;
            yield return new WaitForSeconds(greenTime);
                TurnColor("Red");
                clickable[2] = false;
            yield return new WaitForSeconds(redTime);
            StartCoroutine(Circle3Timer());
        }
    }

    private void Click()
    {
        if(circle.down == true)
        {
            Clicking();
        } 
    }

    private void Fail()
    {
        lSO.lives -= 1;
        if(lSO.lives <= 0 )
        {
            SceneManager.LoadScene("FailScene");
        }
    }

    private void Clicking()
    {
        //Debug.Log("clicking");
        if(clickable[0] == true)
        {
            tools.sewingSteps[0] = true;
            Debug.Log("step 1 complete");
            circle1.SetActive(false);
            Sew01();
            Step2();
            clickable[0] = false;
        } else if(clickable[1] == true)
        {
            tools.sewingSteps[1] = true;
            Debug.Log("step 2 complete");
            circle2.SetActive(false);
            Sew02();
            Step3();
            clickable[1] = false;
        } else if(clickable[2] == true)
        {
            tools.sewingSteps[2] = true;
            Debug.Log("step 3 complete");
            circle3.SetActive(false);
            Sew03();
            clickable[2] = false;
            if(tools.sewingSteps[2] == true)
            {
                tools.sewingComplete = true;
                //use this bool for next step
            }
            //fails:
        }else if(clickable[0] == false)
        {
            if(tools.sewingSteps[0] == false)
            {
                if(tools.sewingSteps[1] == false)
                {
                    if(tools.sewingSteps[2] == false)
                    {
                        Fail();
                    }
                    
                }
             
            }

        }else if(clickable[1] == false)
        {
            if(tools.sewingSteps[0] == true)
            {
                if(tools.sewingSteps[1] == false)
                {
                    if(tools.sewingSteps[2] == false)
                    {
                        Fail();
                    }
                }
            }
        }else if(clickable[2] == false)
        {
            if(tools.sewingSteps[0] == true)
            {
                if(tools.sewingSteps[1] == true)
                {
                    if(tools.sewingSteps[2] == false)
                    {
                        Fail();
                    }
                }
            }
        }
    }

    void Step3()
    {
         if(tools.sewingSteps[1] == true)
        {
            if(clickable[2] == false)
            {
                circle3.SetActive(true);
                circleCtrl3.Play("Circle03", 0, 0.0f);
                played[2] = true;
                StartCoroutine(Circle3Timer());
            }
        }


    }

    private void Step2()
    {
        if(tools.sewingSteps[0] == true)
        {
            if(clickable[1] == false)
            {
                circle2.SetActive(true);
                circleCtrl2.Play("Circle02", 0, 0.0f);
                played[1] = true;
                StartCoroutine(Circle2Timer());
            }
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


    private void Sew01()
    {
        teddyAnim.Play("Sew01", 0, 0.0f);
    }

    private void Sew02()
    {
        teddyAnim.Play("Sew02", 0, 0.0f);

    }

    private void Sew03()
    {
        teddyAnim.Play("Sew03", 0, 0.0f);
    }
}
