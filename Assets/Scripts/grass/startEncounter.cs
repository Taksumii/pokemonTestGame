using System.Collections.Generic;
using UnityEngine;


public class startEncounter : MonoBehaviour
{
    private bool inGrass = false;
    
    
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        inGrass = true;

        while (inGrass == true)
        {

            Delay(1);
            
            int encounterChance = randomChance(0, 100);

            Debug.Log($"2D Triggered");

            if (encounterChance > 90)
            {
                Debug.Log($"Encounter Started");
            }
            
        }

    }


    private IEnumerable<WaitForSeconds> Delay(int delay)
    {
        
        yield return new WaitForSeconds(delay);
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inGrass = false;
    }
    
    
    private int randomChance(int min, int max)
   {
      int num = Random.Range(min, max);
      return num;

   }
}