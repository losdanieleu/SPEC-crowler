using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Des_Boss : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }
       public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spear")
        {
            currentHealth -= 10;
        }
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}