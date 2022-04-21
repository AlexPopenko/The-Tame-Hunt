using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCircleScript : MonoBehaviour
{
    public Transform [] firePots;
    public GameObject firePotPrefab;
    private GameObject activeFirepot;

  private IEnumerator Start()
  {
      while(true)
      {
          
        if(activeFirepot != null)
        {
            Destroy(activeFirepot);
        }
        int index = Random.Range(0, firePots.Length);
        activeFirepot = Instantiate(firePotPrefab, firePots[index].position, Quaternion.identity, firePots[index]);
        yield return new WaitForSeconds(1);
        
      }
  }
   
}
