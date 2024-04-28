using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_Hud : MonoBehaviour
{
    public Text gameOverText;
    public Text pointsText;
    public Text powerUpText;

    public static bool gameOver;
    public static int points;

    private Controller_Player player;

    void Start()
    {
        gameOver = false;
        gameOverText.gameObject.SetActive(false);
        points = 0;
        player = GameObject.Find("Player").GetComponent<Controller_Player>();
    }

    void Update()
    {
        // Actualizar el texto del HUD
        UpdateHUD();

        // Verificar si el juego ha terminado
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverText.text = "Game Over";
            gameOverText.gameObject.SetActive(true);
        }
    }

    // Método para actualizar el texto del HUD
    private void UpdateHUD()
    {
        // Actualizar el texto de los puntos
        pointsText.text = "Score: " + points.ToString();

        // Actualizar el texto del power-up
        if (player != null)
        {
            UpdatePowerUpText();
        }
    }

    // Método para actualizar el texto del power-up
    private void UpdatePowerUpText()
    {
        if (player.powerUpCount <= 0)
        {
            powerUpText.text = "PowerUp: None";
        }
        else if (player.powerUpCount == 1)
        {
            powerUpText.text = "PowerUp: Speed Up";
        }
        else if (player.powerUpCount == 2)
        {
            powerUpText.text = "PowerUp: Missile";
        }
        else if (player.powerUpCount == 3)
        {
            powerUpText.text = "PowerUp: Double shoot";
        }
        else if (player.powerUpCount == 4)
        {
            powerUpText.text = "PowerUp: Laser";
        }
        else if (player.powerUpCount == 5)
        {
            powerUpText.text = "PowerUp: Option";
        }
        else if (player.powerUpCount >= 6)
        {
            powerUpText.text = "PowerUp: Shield";
        }
    }
}