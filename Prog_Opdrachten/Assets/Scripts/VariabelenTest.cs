using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariabelenTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Variabelen aanmaken
        int mijnLeeftijd = 16;
        float mijnLengte = 1.75f;
        string mijnNaam = "Alex";
        bool hebIkHonger = true;

        // Variabelen gebruiken in Debug.Log
        Debug.Log("Mijn naam is: " + mijnNaam);
        Debug.Log("Ik ben " + mijnLeeftijd + " jaar oud");
        Debug.Log("Mijn lengte is: " + mijnLengte + " meter");
        Debug.Log("Heb ik honger? " + hebIkHonger);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
