using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandaging : MonoBehaviour
{
    [SerializeField] private Animator teddyAnim;
    [SerializeField] private ToolsSO tools;
    [SerializeField] private CircleSO cSO;
    [SerializeField] private GameObject clearBandage;

    // Start is called before the first frame update
    void Start()
    {
        tools.bandagingComplete = false;
        clearBandage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(tools.bandaging == true)
        {
            clearBandage.SetActive(true);
            if(cSO.down == true)
            {
                tools.bandagingComplete = true;
                Debug.Log("Surgery Complete");
            }

        }
        
    }
}
