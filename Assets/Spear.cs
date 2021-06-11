using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    public GameObject hitEffect;
    Collider2D colider;

    void OnCollisionEnter2D(Collision2D collision)
    {
       // if (collision.gameObject.tag == "Player")
       // {
           // colider.isTrigger = true;
       // }
      
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            Destroy(gameObject);
        }
    }
}
