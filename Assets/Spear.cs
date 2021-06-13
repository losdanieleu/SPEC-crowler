using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    public GameObject hitEffect;
    Collider2D colider;
    public Transform bulletPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
          GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
          Destroy(effect, 0.5f);
          Destroy(gameObject);  
    }
}
