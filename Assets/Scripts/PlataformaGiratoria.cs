using System.Collections;
using UnityEngine;

public class AspasGiratoriasContrario : MonoBehaviour
{
    public float tiempoMinimo = 3f;
    public float tiempoMaximo = 6f;
    private bool girarEnSentidoAntihorario = true;

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
            girarEnSentidoAntihorario = !girarEnSentidoAntihorario;

            // Girar en la dirección actual durante al menos 3 segundos
            yield return new WaitForSeconds(3f);

            // Cambiar nuevamente la dirección de giro
            girarEnSentidoAntihorario = !girarEnSentidoAntihorario;
        }
    }

    void Update()
    {
        // Girar las aspas en la dirección correspondiente
        if (girarEnSentidoAntihorario)
        {
            // Girar en sentido antihorario
            transform.Rotate(Vector3.forward * Time.deltaTime * 100f);
        }
        else
        {
            // Girar en sentido horario
            transform.Rotate(Vector3.forward * Time.deltaTime * -80f);
        }
    }
}
