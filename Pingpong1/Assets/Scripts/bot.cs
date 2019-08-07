
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot : MonoBehaviour
{
    public float speed = 10;
    public Transform Ball;
    public Transform aimTarget;
    public AudioSource tickSource2;

    public float force = 10;

    public Transform[] targets; 

    Vector3 targetPosition; 
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
        tickSource2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        targetPosition.z = Ball.position.z;
        targetPosition.y = Ball.position.y;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    Vector3 PickTarget(){
        int randomValue = Random.Range(0, targets.Length);
        return targets[randomValue].position;
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Ball")){
            Vector3 dir = PickTarget() - transform.position;
            other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0, 5, 0);
            Debug.Log("Hit the ball");
            tickSource2.Play();
        }
    }
}
