using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;

    public float lowerBounds =-10.0f;

    private ScoreManager scoreManager; //reference score manager to update score 
    private DetectCollision detectCollision;

    void Awake()
    {
       // Time.timeScale = 1;
    }

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // getting the script for scoremanager 
        detectCollision = GetComponent<DetectCollision>(); //doesn't need find game object as this script and detect are both on same object 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

    
       else if(transform.position.z < lowerBounds)
        {
            scoreManager.DecreaseScore(detectCollision.scoreToGive); // decrease score if a ship goes below bounds
            Debug.Log("Game Over"); 
            Destroy(gameObject); 
           // Time.timeScale = 0; (idr why this is here)
        }
    }
}
