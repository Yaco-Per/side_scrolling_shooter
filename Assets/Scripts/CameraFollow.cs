using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Objeto a seguir, en este caso el jugador
    public Vector3 offset; // Desplazamiento de la c�mara desde el jugador

    void LateUpdate()
    {
        if (target != null)
        {
            // Establecer la posici�n de la c�mara para que coincida con la posici�n del jugador m�s el desplazamiento
            transform.position = target.position + offset;
        }
    }
}