using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeepScore : MonoBehaviour
{
    
    public int collectedBooks;
    
    public ParticleSystem particle = null;
    public Text Score;
    // Start is called before the first frame update
    
public AudioSource winSound;
    void addBook(){
        collectedBooks++;
        
        Score.text = "Books Collected: " + collectedBooks.ToString();

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Scorebook"))
        {
            Destroy(other.gameObject);
            addBook();
        }
        if(other.CompareTag("MagicCircle") && collectedBooks >= 4)
        {
            winSound.Play();
            particle.Play();
        }
    }
}
