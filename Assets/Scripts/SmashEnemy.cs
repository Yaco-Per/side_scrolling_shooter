using UnityEngine;

public class SmashEnemy : MonoBehaviour
{
    public string playerTag = "Player"; // Tag del objeto del jugador

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que entra en el trigger es el jugador
        if (other.CompareTag(playerTag))
        {
            // Desactivar el objeto del jugador
            other.gameObject.SetActive(false);

            // Indicar que el jugador ha perdido
            Debug.Log("¡El jugador ha sido aplastado!");
        }
    }
}