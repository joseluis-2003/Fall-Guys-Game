using UnityEngine;

public class MovimientoIzquierdaDerecha : MonoBehaviour
{
    public float speed = 3.0f; // Velocidad del movimiento (ajusta según tus necesidades)
    public float distance = 1.0f; // Distancia total del movimiento (ajusta según tus necesidades)
    private Vector3 initialPosition;
    private float direction = 0.6f; // 1.0f para moverse de derecha a izquierda, -1.0f para izquierda a derecha

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calcula la nueva posición en función del tiempo
        float newPositionX = Mathf.PingPong(Time.time * speed, distance) * direction;

        // Aplica la nueva posición al objeto
        transform.position = initialPosition + new Vector3(newPositionX, 0, 0);
    }
}

