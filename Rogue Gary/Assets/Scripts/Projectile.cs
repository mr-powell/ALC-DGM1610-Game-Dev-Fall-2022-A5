using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed;
    public int damage;
    private Transform player;
    private Vector2 target;


    private Health playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = new Vector2(player.position.x, player.position.y);

        playerHealth = GameObject.Find("Player").GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime); 

       if(transform.position.x == target.x && transform.position.y == target.y)
       {
           DestroyProjectile();
       }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);
            DestroyProjectile();
        }
        if(other.CompareTag("Wall"))
        {
            DestroyProjectile();
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
