using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   public float xSpeed = 3.0f;
   public float ySpeed = 3.0f;
   Rigidbody2D rb;
   public 
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3  (0, ySpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.position += new Vector3  (0, -ySpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-xSpeed * Time.deltaTime, 0, 0);
        }
        

           
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("collided with " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Walls")
        {
            return gameObject.transform.position = spawn;
        }
    }
    
}

