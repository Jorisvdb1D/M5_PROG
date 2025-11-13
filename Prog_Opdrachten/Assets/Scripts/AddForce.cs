using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    public float bewegingsKracht = 10.0f;
    public float springKracht = 300.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.right * 10.0f);
        //rb.AddForce(Vector3.up * 500, ForceMode.Force);
        // rb.AddForce(Vector3.up * 50, ForceMode.Impulse);
        //rb.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
       // rb.velocity = new Vector3(5, 0, 0); // Beweeg 5 units/sec naar rechts
    }

    // Update is called once per frame
    void Update()
    {
        // WASD beweging met physics
        float horizontal = Input.GetAxis("Horizontal"); // A/D toetsen
        float vertical = Input.GetAxis("Vertical");     // W/S toetsen

        // Voeg krachten toe in X en Z richting
        Vector3 beweging = new Vector3(horizontal, 0, vertical);
        rb.AddForce(beweging * bewegingsKracht);

        // Spring met Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * springKracht);
        }

        // Toon huidige snelheid
        Debug.Log("Snelheid: " + rb.linearVelocity.magnitude);
    }
}
