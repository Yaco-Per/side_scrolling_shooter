using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternEnemy : Controller_Enemy
{
    public bool goingUp;
    public bool forward;

    private float timer = 1f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    override public void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            rb.velocity = Vector3.zero;
            if (forward)
            {
                forward = false;
            }
            else
            {
                goingUp = !goingUp;
                forward = true;
            }
            timer = 1f;
        }
        base.Update();
    }

    void FixedUpdate()
    {
        if (forward)
        {
            rb.AddForce(Vector3.left * enemySpeed, ForceMode.Impulse);
        }
        else
        {
            Vector3 direction = goingUp ? Vector3.down : Vector3.up;
            rb.AddForce(Vector3.left * enemySpeed + direction * enemySpeed, ForceMode.Impulse);
        }
    }
}