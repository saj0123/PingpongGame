using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        GameObject.Find("Ball").SendMessage("Finish");
    }
}
