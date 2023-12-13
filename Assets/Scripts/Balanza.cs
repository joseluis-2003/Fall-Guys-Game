using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balanza : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del objeto
    public float distanciaLimite = 5f; // Distancia máxima que recorrerá el objeto

    private bool moverDerecha = true;
    private Vector3 puntoInicial;

    void Start()
    {
        // Guardar la posición inicial del objeto
        puntoInicial = transform.position;
    }

    void Update()
    {
        // Mover el objeto de izquierda a derecha
        if (moverDerecha)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        // Verificar si el objeto ha alcanzado la distancia límite
        if (Vector3.Distance(puntoInicial, transform.position) >= distanciaLimite)
        {
            // Cambiar la dirección del movimiento
            moverDerecha = !moverDerecha;
        }
    }
}
