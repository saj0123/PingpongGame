using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public AudioSource tickSource1;
    public Rigidbody rb;
    void Start()

    {
        tickSource1 = GetComponent<AudioSource>();
    }

    public float fowardForce = 100f;
    // Update is called once per frame
    void FixedUpdate()
    { 
        rb.AddForce(-fowardForce * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Bat")){
            tickSource1.Play();
        }
    }
  
}

   


