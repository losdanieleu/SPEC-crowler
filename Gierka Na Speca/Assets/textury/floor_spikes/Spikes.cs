using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes: MonoBehaviour
{
   public bool spike;
    private Animator anim;
   private void OnTriggerEnter2D(Collider2D collision)
    {
       
       if (collision.tag == "Player")
        { 
            spike = true;
        }
        else
        {
            spike = false;
        }

    }
    void Start()
    {
        
    }

 
    void Update()
    { anim = GetComponent<Animator>();
        
        anim.SetBool("on_spikes", spike);
        
    }
}
