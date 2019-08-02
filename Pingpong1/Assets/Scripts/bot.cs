using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIbot : MonoBehaviour
{
    public float speed = 10;
    public Transform Ball;
    public Transform aimTarget;

    public float force = 10f;

    Vector3 targetPosition; 
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        targetPosition.z = Ball.position.z;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

      private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Ball")){
            Vector3 dir = aimTarget.position - transform.position;
            other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0, 5, 0);
            Debug.Log("Hit the ball");
        }
    }
}
