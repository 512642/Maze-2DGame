﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   public float xSpeed = 3.0f;
   public float ySpeed = 3.0f;
   public float LifeCounter = 3.0f;

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

     public float LifeCounter = 3.0f;
    void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("collided with " + col.gameObject.tag);
        if (col.gameObject.tag == "Walls")
        {
        
        }
    }
    void Lives()
    {
        if (Col.gameObject.tag == "walls")
        {
            LifeCounter--;
            Debug.log(LifeCounter);
        }
    }
}

