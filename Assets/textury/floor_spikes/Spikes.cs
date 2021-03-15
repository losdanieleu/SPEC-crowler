using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes: MonoBehaviour
{
   public bool spike;
    private Animator anim;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            spike = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        spike = false;
    }
    void Start()
    {
      
    }

 
    void Update()
    { anim = GetComponent<Animator>();
    
      anim.SetBool("on_spikes", spike);
        
    }
}
