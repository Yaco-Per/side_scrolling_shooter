using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Objeto a seguir, en este caso el jugador
    public Vector3 offset; // Desplazamiento de la cámara desde el jugador

    void LateUpdate()
    {
        if (target != null)
        {
            // Establecer la posición de la cámara para que coincida con la posición del jugador más el desplazamiento
            transform.position = target.position + offset;
        }
    }
}