using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDelay;
    
    // Start is called before the first frame update
    void Start()
    {
       Time.timeScale = 1;
       currentHealth = maxHealth; 
    }
    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;

        if(currentHealth <= 0)
        {
            Debug.Log("You are dead! Game Over!!");
            Time.timeScale = 0;
            //Destroy(gameObject,deathDelay);
        }
    }
    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth)//Puts a cap on health amount
        {
            currentHealth = maxHealth;
        }
    }
}
