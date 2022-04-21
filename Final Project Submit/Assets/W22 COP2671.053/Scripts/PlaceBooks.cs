using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBooks : MonoBehaviour
{

    public KeepScore keepscore;
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void OnTriggerEnter(Collider other)
{
    if(other.CompareTag("Player"))
        {
            placeBooks();
        }
}
    public void placeBooks(){
        if(keepscore.collectedBooks >= 1)
        {
            gameObject1.SetActive(true);
        }
        if(keepscore.collectedBooks >= 2)
        {
            gameObject2.SetActive(true);
        }
        if(keepscore.collectedBooks >= 3)
        {
            gameObject3.SetActive(true);
        }
        if(keepscore.collectedBooks >= 4)
        {
            gameObject4.SetActive(true);
        }

    }
}
