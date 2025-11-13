using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        // Check of het de Player is
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger!");
            // Doe iets speciaals voor de player
        }

        // Check of het een Enemy is
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy detected!");
            // Reageer op vijanden
        }

        // Check of het een Pickup is
        if (other.gameObject.CompareTag("Pickup"))
        {
            Debug.Log("Pickup found!");
            // Verzamel het item
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
