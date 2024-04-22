using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Instantiator : MonoBehaviour
{
    public float timer = 7;
    public List<GameObject> enemies;
    public GameObject instantiatePos;
    
    // Velocidad inicial y máxima de los enemigos
    public float initialEnemySpeed = 2f;
    public float maxEnemySpeed = 10f;
    
    private float currentEnemySpeed; // Velocidad actual de los enemigos
    private float time = 0;
    private int multiplier = 20;

    void Start()
    {
        // Al iniciar, la velocidad actual es la velocidad inicial
        currentEnemySpeed = initialEnemySpeed;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        SpawnEnemies();
        ChangeVelocity();
    }

    private void ChangeVelocity()
    {
        time += Time.deltaTime;
        if (time > multiplier)
        {
            multiplier *= 2;
            // Incrementar la velocidad actual gradualmente hasta llegar a la velocidad máxima
            currentEnemySpeed = Mathf.Min(currentEnemySpeed * 1.1f, maxEnemySpeed);
        }
    }

    private void SpawnEnemies()
    {
        if (timer <= 0)
        {
            float offsetX = instantiatePos.transform.position.x;
            int rnd = Random.Range(0, enemies.Count);
            for (int i = 0; i < 5; i++)
            {
                offsetX += 4;
                Vector3 position = new Vector3(offsetX, instantiatePos.transform.position.y, instantiatePos.transform.position.z);
                GameObject enemy = Instantiate(enemies[rnd], position, Quaternion.identity);
                
                // Aplicar la velocidad actual al enemigo
                enemy.GetComponent<Controller_Enemy>().enemySpeed = currentEnemySpeed;
            }
            timer = 7;
        }
    }
}