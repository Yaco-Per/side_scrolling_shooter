using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private Vector3 initialPlayerPosition; // Variable que almacena la posición inicial del jugador

    void Start()
    {
        // Guarda la posición inicial de Player del inicio del juego para que al apretar la tecla R, devuelba la posicion inicial
        initialPlayerPosition = Vector3.zero; // La posición inicial es (0, 0, 0)
    }

    void Update()
    {
        // Verificar que se presiona la tecla R
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Llama al método para reiniciar el juego
            RestartGame();
        }
    }

    void RestartGame()
    {
        // Para reiniciar el tiempo de juego
        Time.timeScale = 1;

        // Restablecer la posición del jugador a la posición inicial
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = initialPlayerPosition;
        }

        // Recargar la escena actual (esto reiniciará todos los objetos y componentes)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}