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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 34ec97fb908ab323d140edd83c35ab78a497c510
        // Determina la dirección del movimiento en función de la variable goingUp
        Vector3 moveDirection = goingUp ? Vector3.up : Vector3.down;
        // Aplica una fuerza al Rigidbody en la dirección determinada por moveDirection
        rb.AddForce(new Vector3(-1, 1, 0) * enemySpeed * moveDirection.y);
<<<<<<< HEAD
=======
=======
        // Aplicar una fuerza diagonal al enemigo dependiendo de la dirección de movimiento
        Vector3 forceDirection = goingUp ? new Vector3(-1, 1, 0) : new Vector3(-1, -1, 0);
        rb.AddForce(forceDirection * enemySpeed, ForceMode.Impulse);
>>>>>>> eaeb3a811b33d4281ae76e6f284c8ec0a7d19a9c
>>>>>>> 34ec97fb908ab323d140edd83c35ab78a497c510
    }

    internal override void OnCollisionEnter(Collision collision)
    {
        // Cambia la dirección del movimiento cuando el enemigo colisiona con el suelo o el techo
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