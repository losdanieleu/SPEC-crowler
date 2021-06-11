using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;


public class magtest : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public int maxMana = 150;
    public int currentMana;
    public ManaBar manaBar;

    public float movementspeed;
    public bool flip = true;
    private Rigidbody2D rbBody;

    private Vector2 direction;
    private Animator anim;

    public bool run;
    //public bool spike;
    //public bool chest;
    public Rigidbody2D rb;
    Vector2 movement;
    public float speeed;

    void Flip()
    {
        flip = !flip;
        Vector3 scale = gameObject.transform.localScale;
        scale.x *= -1;
        gameObject.transform.localScale = scale;
    }
    void Turning()
    {
        float pozmove = Input.GetAxis("Horizontal");
        Vector3 skala = gameObject.transform.localScale;

        if (pozmove < 0 && flip == true)
        {
            Flip();
        }

        if (pozmove > 0 && flip == false)
        {
            Flip();
        }
    }

    void Start()
    {
        currentHealth = maxHealth;
        currentMana = maxMana;
        healthBar.SetMaxHealth(maxHealth);
        manaBar.SetMaxMana(maxMana);
        rbBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    /*void is_alive()
    {
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Zdeh");
            Application.Quit();
        }
    }*/
    void Update()
    {
        healthBar.SetHealth(currentHealth);

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        Turning();

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {

            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        };


        if (Input.GetKey(KeyCode.F))
        {
            currentHealth -= 10;
            healthBar.SetHealth(currentHealth);
        }
        if (Input.GetKey(KeyCode.B))
        {
            currentMana -= 30;
            manaBar.SetMana(currentMana);
        }

        if (currentHealth <= 0)
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            
        }

    }

     void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speeed * Time.fixedDeltaTime);
    }

}