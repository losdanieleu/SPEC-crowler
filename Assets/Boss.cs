using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Transform player;
    private bool isLookingRight;

    void Start()
    {
        isLookingRight = true;
    }

    void Flip()
    {
        isLookingRight = !isLookingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        gameObject.transform.localScale = scale;
    }

    void Update()
    {
        if ((player.position.x < transform.position.x) && isLookingRight)
        {
            Flip();
        }
        else
        {
            if ((player.position.x > transform.position.x) && !isLookingRight)
            {
                Flip();
            }
        }
    }
}
