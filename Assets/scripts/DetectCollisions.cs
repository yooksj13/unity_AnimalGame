using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DetectCollisions : MonoBehaviour
{
    float topBound = 25;
    float lowerBound = -6;

    void Update()
    {
        if(transform.position.z > topBound){
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound){
            PlayerController.life -= 1;
            Destroy(gameObject);            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
