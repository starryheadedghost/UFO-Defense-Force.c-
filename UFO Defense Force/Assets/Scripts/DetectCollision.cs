using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //checks for collisions 
    void OnTriggerEnter(Collider other)
    {
        //only activates if the tag is the same 
        if(other.gameObject.CompareTag("BoltContainer"))
        {
        Destroy(other.gameObject); //destroy the game obejct it hits
        Destroy(gameObject); //destroy THIS game object (ufo)
        }
         
    }
}
