using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]  float rotate = 1f;
    [SerializeField]  float steeringspeed = 0.015f;
    [SerializeField]  float speedup = 0.03f;
    [SerializeField]  float speeddown = 0.01f;
    
    void Update()
    {
        float steerspeed =  -Input.GetAxis("Horizontal") * rotate;
        float steerrotate =  Input.GetAxis("Vertical") * steeringspeed;
        transform.Rotate(0,0,steerspeed);
        transform.Translate(0,steerrotate,0);
    }
    private void OnCollisionEnter2D(Collision2D other) {
            steeringspeed = speeddown;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "up"){
            steeringspeed = speedup;
        }
    }
}
