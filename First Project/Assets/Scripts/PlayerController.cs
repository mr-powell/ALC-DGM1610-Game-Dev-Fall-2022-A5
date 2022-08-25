using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string playerName = "Rob Boss";
    
    public int speed; // set speed value
    public float hInput; // store horizontal input from keyboard
    public float vInput; //store vertical input from keyboard
    
    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        // This is the code that moves the player
        transform.Translate(Vector3.right * speed * hInput * Time.deltaTime);// Left and Right movement
            
        transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime);//Forward and Backward movement
    }
}
