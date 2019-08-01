using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBorder : MonoBehaviour
{
   private void OnTriggerEnter(Collider other){
       GameObject.Find("Ball").SendMessage("Stop");
   }
}
