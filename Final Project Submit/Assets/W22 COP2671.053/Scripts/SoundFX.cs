using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundFX : MonoBehaviour
{

    public AudioSource playSound;
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Scorebook"))
        {
            playSound.Play();
        }
    }
}
