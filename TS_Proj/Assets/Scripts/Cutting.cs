using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutting : MonoBehaviour
{
    [SerializeField] private Animator teddyAnim;
    [SerializeField] private ToolsSO tools;
    [SerializeField] private Slider scissorSlider;

    private float cutNum;

    private Animation cutAnim1;
    private Animation cutAnim2;
    private Animation cutAnim3;

    private void Awake()
    {
      scissorSlider.gameObject.SetActive(false);
    }

  private void Start()
  {
    tools.cuttingSteps[0] = false;
    tools.cuttingSteps[1] = false;
    tools.cuttingSteps[2] = false;
    tools.cuttingComplete = false;
  }

  private void Update()
  {
    if(tools.cutting == true)
    {
        scissorSlider.gameObject.SetActive(true);

        scissorSlider.onValueChanged.AddListener((i) => {
            cutNum = i;

            switch(cutNum)
            {
                case 1:
                if(tools.cuttingSteps[0] == false)
                {
                    PlayAnim1();
                    tools.cuttingSteps[0] = true;
                }
                break;
                
                case 2:
                if(tools.cuttingSteps[1] == false)
                {
                    PlayAnim2();
                    tools.cuttingSteps[1] = true;
                }
                break;

                case 3:
                if(tools.cuttingSteps[2] == false)
                {
                    PlayAnim3();
                    tools.cuttingSteps[2] = true;
                    tools.cuttingComplete = true;
                    Off();
                }
                break;
            }
        });
    }else if(tools.cutting == false)
    {
        scissorSlider.gameObject.SetActive(false);
    }
  }

    private void PlayAnim1()
  {
    teddyAnim.Play("Cut01", 0, 0.0f);
  }

  private void PlayAnim2()
  {
    teddyAnim.Play("Cut02", 0, 0.0f);
  }

  private void PlayAnim3()
  {
    teddyAnim.Play("Cut03", 0, 0.0f);
  }

  private void Off()
  {
    tools.cutting = false;
    tools.areScissorsSelected = false;
    tools.injectingComplete = true;
    tools.sewingComplete = false;
    tools.bandagingComplete = false;
    //tools.sewingComplete = true;
  }
}




  

  



 



