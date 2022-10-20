using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameManager gm;// GameManager Script
    public float doorDelay = 0.5f; // How long it will take to open door

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); // Find GameManager object and then reference script component 
    }   

    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.CompareTag("Player") && gm.key >= 1)
        {
            Destroy(gameObject, doorDelay);
            gm.key --;//Subtract one key
            //Troubleshooting feedback
            Debug.Log("Keys = "+ gm.key);
            Debug.Log("Door is open!");
        }
        else
        {
            Debug.Log("Door is locked. You need a key!"); 
        }   
    }
   
}
