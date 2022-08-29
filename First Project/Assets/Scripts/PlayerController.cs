using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
        
    public int speed; // Set speed value
    public float rotSpeed; // Set rotation speed
    public float hInput; // Store horizontal input from keyboard
    public float vInput; //Store vertical input from keyboard
    
    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        // This is the code that moves the player
        transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime);
        // Left and Right rotation            
        transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime);//Forward and Backward movement
    }
}
