using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_EnemyProjectile : Projectile
{
    private Vector3 direction;

    private Rigidbody rb;

    public float enemyProjectileSpeed;

    void Start()
    {
        SetDirection();
        rb = GetComponent<Rigidbody>();
    }

    void SetDirection()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            direction = (player.transform.position - transform.position).normalized;
        }
        else
        {
            direction = transform.forward; // Fallback to forward direction if player is not found
        }
    }

    public override void Update()
    {
        rb.velocity = direction * enemyProjectileSpeed;
        base.Update();
    }
}