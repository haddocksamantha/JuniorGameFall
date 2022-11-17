using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class Injecting : MonoBehaviour
{
   [SerializeField] private ToolsSO tools;
   [SerializeField] private Vector3SO vSO;
   [SerializeField] private CircleSO cSO;
   [SerializeField] private GameObject syRig;
   [SerializeField] private GameObject syTool;
   
     private GameObject syGlow;
     private GameObject circle;
     private bool circleActive;
     private bool oneCircle;
     private bool timerRun;

     //public Vector3 circleTrans = new Vector3();
     private Vector3 num = new Vector3();
     public GameObject circlePrefab;


     private void Awake()
     {
          tools.injecting = false;
          tools.injectingComplete = false;
          syRig.SetActive(false);
     }
    
 
   private void Start()
   {
     oneCircle = false;
     timerRun = false;
   }

   private void Update()
   {
     Injection();
   }

   private void Injection()
   {

     Timing();
     
     if(tools.injectingComplete == false)
     {
          if(Input.GetMouseButtonDown(0))
          { 
               if(cSO.down == true)
               {
                    
                    Clicking();
               }
          }
     }
   }

   private void Timing()
   {
     if(tools.injecting == true)
     {
          if(timerRun == false)
          {   
               StartCoroutine(CircleTimer());
               timerRun = true;
          }
     }
   }

   private void Clicking()
   {
     if(circleActive == true)
     {
          if(cSO.down == true )
          {
               cSO.down = false;
               
               if(oneCircle == true)
               {

               Destroy(circle);

               syGlow = GameObject.FindWithTag("syGlow");
               StartCoroutine(SyringeAnim(1.5f));

               tools.injectingComplete = true;  
               }
          }
     }
   }

   IEnumerator SyringeAnim(float seconds)
   {
     syRig.SetActive(true);
     syTool.SetActive(false);
     syGlow.SetActive(false);
     yield return new WaitForSeconds(seconds);
     syRig.SetActive(false);
     syTool.SetActive(true);
   }



   private void NeedleFlash()
   {
        //Debug.Log("shouldn't inject");
        //flash needle
   }

   IEnumerator CircleTimer()
     {
          if(tools.injectingComplete == false)
          {
               //Debug.Log("Injecting (circle created)");
               float lifeTime = 0.15f;
               float spacing = 0.3f;

                    CircleGen();

                    circleActive = true;
               yield return new WaitForSeconds(lifeTime);
                    circleActive = false;
                    Destroy(circle);
                    oneCircle = false;
                    //Debug.Log("circle destroyed");
               yield return new WaitForSeconds(spacing);
                    StartCoroutine(CircleTimer());
               timerRun = false;
          }
     }

   private void CircleGen()
     {
          if(oneCircle == false)
          {
               // should choose random num from array
               //num = vSO.circleLocations[Random.Range(0, vSO.circleLocations.Length)]; 

               // this fixes spawning location problem
               float x = Random.Range(0.061f,-0.076f);
               float y = 0.109f;
               float z = Random.Range(0.1547f,0.0075f);

               num = new Vector3(x, y, z);
               //assigns value to new vector 3
               //obj, tranform, rotation
               circle = Instantiate(circlePrefab, num, Quaternion.identity);
               //Debug.Log(circle.transform.position);
               oneCircle = true;
          }
     }

     
}
