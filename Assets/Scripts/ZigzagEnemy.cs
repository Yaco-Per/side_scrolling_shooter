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
        // Aplicar una fuerza diagonal al enemigo dependiendo de la dirección de movimiento
        Vector3 forceDirection = goingUp ? new Vector3(-1, 1, 0) : new Vector3(-1, -1, 0);
        rb.AddForce(forceDirection * enemySpeed, ForceMode.Impulse);
    }

    internal override void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            goingUp = true;
        }
        else if (collision.gameObject.CompareTag("Ceiling"))
        {
            goingUp = false;
        }

        base.OnCollisionEnter(collision);
    }
}