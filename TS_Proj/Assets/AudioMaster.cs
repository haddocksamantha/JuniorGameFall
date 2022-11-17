using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMaster : MonoBehaviour
{

    public AudioSource source;

    public AudioClip win;
    public AudioClip button;
    public AudioClip sew;
   

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

 

   
  
    
}
