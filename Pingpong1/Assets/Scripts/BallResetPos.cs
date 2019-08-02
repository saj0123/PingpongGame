using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallResetPos : MonoBehaviour
{
   public Vector3 startPos;
   private bool stop = false;

   

   void update(){
       if(stop)
        return; 
       startPos = transform.position; 
   }

   public void Stop(){
       stop = true;
       transform.position = startPos;
   }
   
}
