using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private ScoreManager scoreManager; //references scoremanager 

    public int scoreToGive;

    public ParticleSystem explosionParticle; //store particle system wowow

    //audio
    private AudioSource exploadAudio;
    public AudioClip expload;

    // Start is called before the first frame update
    void Start()
    {
         exploadAudio = GetComponent<AudioSource>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //get scoremanager component 
    }

    //checks for collisions 
    void OnTriggerEnter(Collider other)
    {
        //only activates if the tag is the same 
        if(other.gameObject.CompareTag("BoltContainer"))
        {
        Destroy(other.gameObject); //destroy the game obejct it hits
        Destroy(gameObject); //destroy THIS game object (ufo)
        Explosion();
        }


        scoreManager.IncreaseScore(scoreToGive); //increase score
         
    }

    void Explosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
        exploadAudio.PlayOneShot(expload,0.5f);
    }
    

}
