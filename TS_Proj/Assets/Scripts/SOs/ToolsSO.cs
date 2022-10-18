using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]

public class ToolsSO : ScriptableObject
{
    public bool areScissorsSelected;
    public bool isNeedleSelected;
    public bool isSyringeSelected;
    public bool isBandaidSelected;

    public int sMaxGlow;
    public int nMaxGlow;
    public int syMaxGlow;
    public int bMaxGlow;

    public bool cutting;
    public bool cuttingComplete;

    public bool sewing;
    public bool sewingComplete;

    public bool injecting;
    public bool injectingComplete;

    public bool bandaging;
    public bool bandagingComplete;
}
