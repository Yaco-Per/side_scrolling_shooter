using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
<<<<<<< HEAD
    public Vector3 initialPlayerPosition = new Vector3(-8.24f, 6f, 0f); // Posición inicial del jugador
=======
<<<<<<< HEAD
    private Vector3 initialPlayerPosition = new Vector3(-8.24f, 6f, 0f); // Posición inicial del jugador
>>>>>>> 34ec97fb908ab323d140edd83c35ab78a497c510

    void Update()
    {
        // Verificar si se presiona la tecla R
        if (Input.GetKeyDown(KeyCode.R))
        {
<<<<<<< HEAD
            // Llamar al método para reiniciar el juego
=======
            // Llamar a un método para reiniciar el juego
=======
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
>>>>>>> eaeb3a811b33d4281ae76e6f284c8ec0a7d19a9c
>>>>>>> 34ec97fb908ab323d140edd83c35ab78a497c510
            RestartGame();
        }
    }

    void RestartGame()
    {
<<<<<<< HEAD
        // Reiniciar el tiempo de juego
        Time.timeScale = 1;

        // Mover al jugador a la posición inicial
=======
<<<<<<< HEAD
        // Reiniciar el tiempo de juego
        Time.timeScale = 1;

        // Buscar al jugador y moverlo a la posición inicial si se encuentra
=======
        // Para reiniciar el tiempo de juego
        Time.timeScale = 1;

        // Restablecer la posición del jugador a la posición inicial
>>>>>>> eaeb3a811b33d4281ae76e6f284c8ec0a7d19a9c
>>>>>>> 34ec97fb908ab323d140edd83c35ab78a497c510
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = initialPlayerPosition;
        }

<<<<<<< HEAD
        // Recargar la escena actual
=======
        // Recargar la escena actual (esto reiniciará todos los objetos y componentes)
>>>>>>> 34ec97fb908ab323d140edd83c35ab78a497c510
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}