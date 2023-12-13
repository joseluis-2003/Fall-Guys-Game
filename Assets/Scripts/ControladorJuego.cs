using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJuego : MonoBehaviour
{
    // La etiqueta [SerializeField] permite que las variables
    // privadas sean visibles en el Inspector de Unity.
    [SerializeField] private float tiempoMaximo;
    [SerializeField] private Slider slider;
    // Almacena el tiempo actual restante en el temporizador.
    private float tiempoActual;
    // Indica si el temporizador está actualmente activo o inactivo.

    private bool tiempoactivo = false;

    void Update()
    {
        ActivarTemporizador();
    }
    // Comprueba si el tiempo ha llegado a cero y realiza acciones en consecuencia.
    private void CambiarContador()
    {
        tiempoActual -= Time.deltaTime;
        if (tiempoActual >= 0)
        {
            slider.value = tiempoActual;
        }
        if(tiempoActual <= 0)
        {
            Debug.Log("Derrota");
            cambiarTemporizador(false);
        }
    }
    // Este métod cambia el estado del temporizador (activo o inactivo).

    private void cambiarTemporizador(bool estado)
    {
        tiempoactivo = estado;
    }
    // Este métod activa el temporizador, establece el tiempo actual y configura el valor máximo del slider.

    public void ActivarTemporizador()
    {
        tiempoActual = tiempoMaximo;
        slider.maxValue = tiempoMaximo;
        cambiarTemporizador(true);
    }
    // Este métod desactiva el temporizador.

    public void DesactivarTemporizador()
    {
        cambiarTemporizador(false);
    }
}

