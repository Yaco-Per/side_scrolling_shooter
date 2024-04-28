using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private Vector3 initialPlayerPosition = new Vector3(-8.24f, 6f, 0f); // Posición inicial del jugador

    void Update()
    {
        // Verificar si se presiona la tecla R
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Llamar a un método para reiniciar el juego
            RestartGame();
        }
    }

    void RestartGame()
    {
        // Reiniciar el tiempo de juego
        Time.timeScale = 1;

        // Buscar al jugador y moverlo a la posición inicial si se encuentra
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = initialPlayerPosition;
        }

        // Recargar la escena actual (esto reiniciará todos los objetos y componentes)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}