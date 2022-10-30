using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SewingAnimations : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;
    [SerializeField] private Animator teddyAnim;

    private Animation sew01;
    private Animation sew02;
    private Animation sew03; 

    private bool[] played = {false, false, false};

    private void Start()
    {
        played[0] = false;
        played[1] = false;
        played[2] = false;
    }

   private void Update()
   {
    if(Input.GetMouseButtonDown(0))
    {
        if(tools.sewing == true)
        {
            if(tools.sewingSteps[0] == true)
            {
                firstAnim();
            }else if(tools.sewingSteps[1] == true)
            {
                secondAnim();
            }else if(tools.sewingSteps[2] == true)
            {
                thirdAnim();
            }
        }
        
    }
   }

   private void firstAnim()
   {
    if(played[0] == false)
    {
        teddyAnim.Play("Sew01", 0, 0.0f);
        played[0] = true;
    }
   }

   private void secondAnim()
   {
    if(played[1] == false)
    {
        teddyAnim.Play("Sew02", 0, 0.0f);
        played[1] = true;
    }
   }

   private void thirdAnim()
   {
    if(played[2] == false)
    {
        teddyAnim.Play("Sew03", 0, 0.0f);
        played[2] = true;
    }

   }
}
