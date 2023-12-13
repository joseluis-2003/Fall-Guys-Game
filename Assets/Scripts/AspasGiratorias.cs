using System.Collections;
using UnityEngine;

public class AspasGiratorias : MonoBehaviour
{
    public float tiempoMinimo = 3f;
    public float tiempoMaximo = 6f;
    private bool girarEnSentidoHorario = true;

    void Start()
    {
        // Iniciar la corutina cuando se inicia el objeto
        StartCoroutine(CambiarDireccionDeGiro());
    }

    IEnumerator CambiarDireccionDeGiro()
    {
        while (true)
        {
            // Esperar un tiempo aleatorio entre tiempoMinimo y tiempoMaximo
            yield return new WaitForSeconds(Random.Range(tiempoMinimo, tiempoMaximo));

            // Cambiar la dirección de giro
            girarEnSentidoHorario = !girarEnSentidoHorario;

            // Girar en la dirección actual durante al menos 3 segundos
            yield return new WaitForSeconds(3f);

            // Cambiar nuevamente la dirección de giro
            girarEnSentidoHorario = !girarEnSentidoHorario;
        }
    }

    void Update()
    {
        // Girar las aspas en la dirección correspondiente
        if (girarEnSentidoHorario)
        {
            // Girar en sentido horario
            transform.Rotate(Vector3.up * Time.deltaTime * 100f);
        }
        else
        {
            // Girar en sentido antihorario
            transform.Rotate(Vector3.up * Time.deltaTime * -80f);
        }
    }
}
