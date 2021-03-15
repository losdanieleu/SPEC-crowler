using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatAtk : MonoBehaviour
{
    public bool atk;
    private Animator anim;

    public void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.gameObject.tag == "Player") 
        {
           atk= true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
       atk = false;
    }



    void Update()
    {
        anim = GetComponent<Animator>();

        anim.SetBool("Attack", atk);

    }
}
