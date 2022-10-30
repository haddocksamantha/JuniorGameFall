using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class Injecting : MonoBehaviour
{
   [SerializeField] private ToolsSO tools;
   [SerializeField] private Vector3SO vSO;
   [SerializeField] private CircleSO cSO;

     private  GameObject circle;
     private bool circleActive;
     private bool oneCircle;

     //public Vector3 circleTrans = new Vector3();
     private Vector3 num = new Vector3();
     public GameObject circlePrefab;
    

   private void Update()
   {
        if(tools.injecting == true)
        {
            if(tools.sewingComplete == true)
            {
               StartCoroutine(CircleTimer());
            }else if(tools.injecting == false)
            {
                //can't inject
                NeedleFlash();
            }  
        }

        if(Input.GetMouseButtonDown(0))
        {
          if(cSO.down == true)
          {
               Clicking();
          }
        }
   }

   private void Clicking()
   {
     if(circleActive == true)
     {
          if(cSO.down == true )
          {
               if(oneCircle == true)
               //tools.injectingComplete = true;
               Debug.Log("injected!");
               Destroy(circle);
          }
         
     }
   }

   private void Start()
   {
     //circle = circlePrefab;
     tools.injectingComplete = false;
     oneCircle = false;
   }

   private void NeedleFlash()
   {
        Debug.Log("shouldn't inject");
        //flash needle
   }

   private void CircleGen()
     {
          if(oneCircle == false)
          {
               // should choose random num from array
               //num = vSO.circleLocations[Random.Range(0, vSO.circleLocations.Length)]; 

               // this fixes spawning location problem
               int x = Random.Range(0,2);
               int y = Random.Range(2,4);
               int z = Random.Range(0,5);

               num = new Vector3(x, y, z);
               //assigns value to new vector 3
               //obj, tranform, rotation
               circle = Instantiate(circlePrefab, num, Quaternion.identity);
               Debug.Log(circle.transform.position);
               oneCircle = true;
          }
     }

     IEnumerator CircleTimer()
     {
          if(tools.injectingComplete == false)
          {
               Debug.Log("Injecting");
               float lifeTime = 3f;
               float spacing = 0.3f;

                    CircleGen();

                    circleActive = true;
               yield return new WaitForSeconds(lifeTime);
                    Destroy(circle);
                    oneCircle = false;
                    Debug.Log("circle destroyed");
                    circleActive = false;
               yield return new WaitForSeconds(spacing);
                    StartCoroutine(CircleTimer());
          }
     }
}
