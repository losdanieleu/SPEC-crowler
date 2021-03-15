using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class magtest : MonoBehaviour
{
    public bool alive;
    public float movementspeed;
    public bool flip = true;
    private Rigidbody2D rbBody;

	public int maxHealth = 100;
	public int currentHealth;
	public HealthBar healthBar;
	
	public int maxMana = 200;
	public int currentMana;
	public ManaBar manaBar;

    private Vector2 direction;
    private Animator anim;

    public bool run;
    //public bool spike;
    //public bool chest;



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
        rbBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		currentMana = maxMana;
		manaBar.SetMaxMana(maxMana);
    }

    

    void Update()
    {
        move();
        Turning();

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {

            anim.SetBool("run", true);
        }
        else
        {

            anim.SetBool("run", false);
        }
    }

    //============================PORUSZANIE=========================================
    public void move()
    {
        GetInput();
        transform.Translate(direction * movementspeed * Time.deltaTime);
        //rbBody.velocity = direction * movementspeed;
        //rbBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movementspeed, Input.GetAxisRaw("Vertical") * movementspeed);
    }

    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(5);
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			LoseMana(10);
		}
        Debug.Log(direction);
    }
	
	void TakeDamage(int damage)
	{
		 currentHealth -= damage;
		 healthBar.SetHealth(currentHealth);
	}
	void LoseMana(int manalose)
	{
		 currentMana -= manalose;
		 manaBar.SetMana(currentMana);
	}
	

}