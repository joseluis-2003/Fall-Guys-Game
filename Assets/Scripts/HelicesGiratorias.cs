using UnityEngine;

public class HelicesGiratorias : MonoBehaviour
{
    public float velocidadGiro = 200f; // Velocidad de giro de las hélices

    void Update()
    {
        // Girar las hélices en la dirección correspondiente
        transform.Rotate(Vector3.up * velocidadGiro * Time.deltaTime);
    }
}
