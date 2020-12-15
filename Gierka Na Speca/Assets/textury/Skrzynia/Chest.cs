using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public bool chest;
    private Animator anim;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        chest = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        chest = false;
    }
 


    void Update()
    {
        anim = GetComponent<Animator>();

        anim.SetBool("chest_on", chest);

    }
}

