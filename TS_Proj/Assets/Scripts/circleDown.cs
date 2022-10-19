using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleDown : MonoBehaviour
{
    [SerializeField] private CircleSO circle;

    void Start()
    {
        circle.down = false;
    }

    void OnMouseDown()
    {
        circle.down = true;
    }

    void OnMouseUp()
    {
        circle.down = false;
    }
}
