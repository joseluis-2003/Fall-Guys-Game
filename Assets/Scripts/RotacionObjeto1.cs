using UnityEngine;

public class RotacionObjeto1 : MonoBehaviour
{
    // Velocidad de rotación en grados por segundo
    public float velocidadRotacion = 90f;

    // Ángulo total a rotar antes de volver a la posición original
    public float anguloTotal = 90f;

    // Indicador de dirección de rotación (1 para derecha, -1 para izquierda)
    public int direccion = 1;

    void Update()
    {
        // Calcula la rotación a aplicar en cada frame
        float rotacionActual = velocidadRotacion * direccion * Time.deltaTime;

        // Rota el objeto
        transform.Rotate(Vector3.up, rotacionActual);

        // Actualiza el ángulo total restante
        anguloTotal -= Mathf.Abs(rotacionActual);

        // Si se ha alcanzado el ángulo total, cambia la dirección y reinicia el ángulo total
        if (anguloTotal <= 0)
        {
            direccion *= -1;
            anguloTotal = 90f;
        }
    }
}
