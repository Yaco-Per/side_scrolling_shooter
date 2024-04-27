using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Instantiator : MonoBehaviour
{
    public float timer = 4; // Intervalo de tiempo entre cada oleada de enemigos
    public List<GameObject> enemies; // Lista de enemigos
    public GameObject instantiatePos; // Posición donde instanciar los enemigos

    public float initialEnemySpeed = 1f; // Velocidad inicial de los enemigos
    public float maxEnemySpeed = 10f; // Velocidad máxima de los enemigos

    private float currentEnemySpeed; // Velocidad actual de los enemigos
    private int pointsForSpeedIncrease = 10; // Puntos necesarios para aumentar la velocidad
    private int previousPoints; // Puntos en la última verificación de velocidad
    private int speedIncreaseCount; // Cantidad de aumentos de velocidad aplicados

    void Start()
    {
        currentEnemySpeed = initialEnemySpeed; // Al iniciar, la velocidad actual es la velocidad inicial
        previousPoints = Controller_Hud.points; // Establecer los puntos iniciales
    }

    void Update()
    {
        timer -= Time.deltaTime; // Decrementar el temporizador

        // Verificar si es hora de instanciar una nueva oleada de enemigos
        if (timer <= 0)
        {
            SpawnEnemies(); // Instanciar enemigos
            timer = 4; // Reiniciar el temporizador
        }

        // Verificar si se alcanzaron los puntos necesarios para aumentar la velocidad
        if (Controller_Hud.points >= previousPoints + pointsForSpeedIncrease)
        {
            IncreaseEnemySpeed(); // Aumentar la velocidad de los enemigos
            previousPoints = Controller_Hud.points; // Actualizar los puntos previos
        }
    }

    // Método para aumentar la velocidad de los enemigos
    private void IncreaseEnemySpeed()
    {
        speedIncreaseCount++; // Incrementar el contador de aumentos de velocidad
        currentEnemySpeed = Mathf.Min(initialEnemySpeed + speedIncreaseCount, maxEnemySpeed); // Incrementar la velocidad
    }

    // Método para instanciar enemigos
    private void SpawnEnemies()
    {
        float offsetX = instantiatePos.transform.position.x; // Posición inicial en el eje X

        // Instanciar un enemigo de cada tipo
        for (int i = 0; i < enemies.Count; i++)
        {
            Vector3 position = new Vector3(offsetX + (i * 4), instantiatePos.transform.position.y, instantiatePos.transform.position.z);
            GameObject enemy = Instantiate(enemies[i], position, Quaternion.identity);

            // Aplicar la velocidad actual al enemigo
            enemy.GetComponent<Controller_Enemy>().enemySpeed = currentEnemySpeed;
        }
    }
}