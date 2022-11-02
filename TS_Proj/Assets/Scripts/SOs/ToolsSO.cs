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
    public bool[] cuttingSteps = {false, false, false};
    public bool cuttingComplete;

    public bool heartRemoved;
    public bool heartAdded;

    public bool sewing;
    public bool[] sewingSteps = {false, false, false};
    public bool sewingComplete;

    public bool injecting;
    public bool injectingComplete;

    public bool bandaging;
    public bool bandagingComplete;
}
