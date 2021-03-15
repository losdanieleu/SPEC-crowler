using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public bool chest;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            chest = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        chest = false;
    }
 


    void Update()
    {
        

         anim.SetBool("chest_on", chest);

    }
}
