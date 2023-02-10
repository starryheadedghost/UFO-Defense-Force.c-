using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;

    public float speed;

    public float xRange;

    public Transform blaster;

    public GameObject laserBolt;



    /*just a test 
    public float verticalInput;
    */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //set float to get commands from keyboard 
        horizontalInput = Input.GetAxis("Horizontal");

    // movs the player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keep playing within left side of bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
        
        //keeps player within right side of bounds
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
        // if space is pressed then pew pew
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // create laser bolt at the child 
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
        /*testing to get the player to go up and down on the x axis
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
         it makes it go on the y axis, don't know why I didn't see that coming */
         
    }
}
