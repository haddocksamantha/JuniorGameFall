using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMaster : MonoBehaviour
{

    [SerializeField] private ToolsSO tools;

    public AudioSource source;

    public AudioClip win;
    public AudioClip button;
    public AudioClip sew;
    public AudioClip yay;
    public AudioClip cut;
    public AudioClip bandage;
    public AudioClip inject;

    void Update()
    {
        if(tools.injectingComplete == true)
        {
            InjectSound();
            
        }else if(tools.cuttingSteps[0] == true)
        {
            CutSound();

        }
        else if(tools.cuttingSteps[1] == true)
        {
            CutSound();

        }else if(tools.cuttingSteps[2] == true)
        {
            CutSound();
        }
        else if(tools.sewingSteps[0] == true)
        {
            SewSound();

        }else if(tools.sewingSteps[1] == true)
        {
            SewSound();
        }else if(tools.sewingSteps[2] == true)
        {
            SewSound();
        }
        else if(tools.bandagingComplete == true)
        {
            BandageSound();
        }

    }

    public void InjectSound()
    {
        source.PlayOneShot(inject);

    }

    public void ButtonSound() 
    {
        source.PlayOneShot(button);

    }

    public void WinSound()
    {
        source.PlayOneShot(win);

    }
    
    public void SewSound()
    {
        source.PlayOneShot(sew);

    }

    public void YaySound()
    {
        source.PlayOneShot(yay);

    }

    public void CutSound()
    {
        source.PlayOneShot(cut);
    }

    public void BandageSound()
    {
        source.PlayOneShot(bandage);
    }
}
