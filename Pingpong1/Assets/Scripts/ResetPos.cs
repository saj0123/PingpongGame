using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
    }

    void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("Wall")){
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = initialPos;
            if (collision.transform.name == "Border")
            {
                Score.Scoredisplayed += 1;
            }
        }
    }

    
}
