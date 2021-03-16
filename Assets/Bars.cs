using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bars : MonoBehaviour
{
    public bool bar;
    private Animator anim;

    private void Start()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bar = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        bar = false;
    }



    void Update()
    {
        anim = GetComponent<Animator>();

        anim.SetBool("bar", bar);

    }
}
