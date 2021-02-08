using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Szczur : MonoBehaviour
{

    void Start()
    {

    }

    public Transform player;

    public Vector2 offset;

    void Update()
    {

        transform.position = new Vector2(player.position.x + offset.x, player.position.y + offset.y); // Camera follows the player with specified offset position
    }
}