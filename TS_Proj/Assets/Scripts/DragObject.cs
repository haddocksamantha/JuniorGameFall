using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    [SerializeField] private ToolsSO tools;

    private Vector3 mOffset;

    private float mZCoord;
    private float height = 0.13f;
/* 
    private void Update()
    {
        //Debug.Log("heart pos: " + transform.position);
    } */

    void OnMouseDown()
    {
        if(tools.cuttingComplete == true)
        {
            if(tools.sewingComplete == false)
            {
                mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        transform.position = new Vector3(transform.position.x, height, transform.position.z);
        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();


            }
               
        }
        
        
     
        
       
    }



    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        if(tools.cuttingComplete == true)
        {
             Rigidbody heartRigidbody = gameObject.GetComponent<Rigidbody> ();
        heartRigidbody.isKinematic = true; 
        transform.position = GetMouseAsWorldPoint() + mOffset;

        }
        
        
       
        
    }

    void OnMouseUp()
    {
        if(tools.cuttingComplete == true)
        {
             Rigidbody heartRigidbody = gameObject.GetComponent<Rigidbody> ();
        heartRigidbody.isKinematic = false;

        }
       
        
       
        
    }

}
 

