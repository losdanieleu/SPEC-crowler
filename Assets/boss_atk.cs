using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_atk : MonoBehaviour
{
    public bool atk;
    private Animator anim;
    public magtest Player;
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            atk = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        atk = false;
    }

    void Update()
    {
        if (atk == true)
        {
            Player.currentHealth -= 10;
        }


        anim = GetComponent<Animator>();

        anim.SetBool("Attack", atk);

    }
}
