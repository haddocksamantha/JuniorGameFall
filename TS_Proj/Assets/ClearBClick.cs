using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearBClick : MonoBehaviour
{
    [SerializeField] private BandaidSO bandage;

    void Awake()
    {
        bandage.clicked = false;
    }

    void OnMouseDown()
    {  
        bandage.clicked = true; 

    }
}
