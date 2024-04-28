using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigzagEnemy : Controller_Enemy
{
    public bool goingUp;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Determina la dirección del movimiento en función de la variable goingUp
        Vector3 moveDirection = goingUp ? Vector3.up : Vector3.down;
        // Aplica una fuerza al Rigidbody en la dirección determinada por moveDirection
        rb.AddForce(new Vector3(-1, 1, 0) * enemySpeed * moveDirection.y);
    }

    internal override void OnCollisionEnter(Collision collision)
    {
        // Cambia la dirección del movimiento cuando el enemigo colisiona con el suelo o el techo
        if (collision.gameObject.CompareTag("Floor"))
        {
            goingUp = true;
        }
        if (collision.gameObject.CompareTag("Ceiling"))
        {
            goingUp = false;
        }
        base.OnCollisionEnter(collision);
    }
}