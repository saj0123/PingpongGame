using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlosewall : MonoBehaviour
{
    public AudioSource tickSource3;
    // Start is called before the first frame update
    void Start()
    {
        tickSource3 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "ball")
        {
            tickSource3.Play();
            Scoresystem.Score -= 1;
        }
    }
}
