using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Des_Sz : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spear")
        {
            Destroy(gameObject);
        }
    }
}
