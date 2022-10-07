using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Pickup
{
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
       gm = GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gm.AddKey(amount);
            Destroy(gameObject);//Destroy pickup
        }
    }
}
