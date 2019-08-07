﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMovement : MonoBehaviour
{
    public Transform aimTarget;
    public float moveSpeed = 0.5f; 
    public float force = 10f;
    public AudioSource tickSource1;

    bool hitting;

    Vector3 aimTargetPosition;

    public Transform[] targets;

    void Start(){
      aimTargetPosition = aimTarget.position; 
      tickSource1 = GetComponent<AudioSource>();
    }

    void Update(){
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical"); 

        if((h != 0 || v!=0)){
            transform.Translate(new Vector3 (h, 0, v) * moveSpeed * Time.deltaTime );
            //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxisRaw("Vertical") * Time.deltaTime);
        }

    }

    Vector3 PickTarget(){
        int randomValue = Random.Range(0, targets.Length);
        return targets[randomValue].position;
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Ball")){
            Vector3 dir = PickTarget() - transform.position;
            other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0, 5, 0);
            tickSource1.Play();
        }

     
    }

}