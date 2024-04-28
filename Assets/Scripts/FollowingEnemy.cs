using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingEnemy : Controller_Enemy
{
<<<<<<< HEAD
    private GameObject player;
=======
    private GameObject player; 

>>>>>>> eaeb3a811b33d4281ae76e6f284c8ec0a7d19a9c
    private Rigidbody rb;
    private Vector3 direction;

    void Start()
    {
        // Buscar al jugador al iniciar
        if (Controller_Player._Player != null)
        {
            player = Controller_Player._Player.gameObject;
        }
        else
        {
            player = GameObject.Find("Player");
        }
        rb = GetComponent<Rigidbody>();
    }

    public override void Update()
    {
        if (player != null)
        {
            // Calcular la dirección hacia el jugador
            direction = -(this.transform.localPosition - player.transform.localPosition).normalized;
        }
        base.Update();
    }

    void FixedUpdate()
    {
        // Aplicar fuerza en la dirección del jugador con la velocidad actual
        if (player != null)
            rb.AddForce(direction * enemySpeed);
    }
}