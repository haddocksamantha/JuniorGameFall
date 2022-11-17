using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bandaging : MonoBehaviour
{
    //[SerializeField] private Animator teddyAnim;
    [SerializeField] private ToolsSO tools;
    [SerializeField] private BandaidSO bandageSO;
    [SerializeField] private CircleSO cSO;
    [SerializeField] private GameObject clearBandage;
    [SerializeField] private GameObject bandageTool;
    [SerializeField] private GameObject bandage;

    // Start is called before the first frame update
    private void Awake()
    {
        bandage.SetActive(false);
    }

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
        }
        
        if(bandageSO.clicked == true)
        {
            StartCoroutine(BandageTimer(1.5f));
        }
    }

    IEnumerator BandageTimer(float waitTime)
    {
        clearBandage.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        bandage.SetActive(true);
        //clearBandage.SetActive(false);
        yield return new WaitForSeconds(waitTime);
        LoadWin();
    }

    public void LoadWin()
    {
        SceneManager.LoadScene("WinScene");
    }
}
