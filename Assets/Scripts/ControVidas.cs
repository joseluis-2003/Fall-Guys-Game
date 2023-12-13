using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ControlVidas : MonoBehaviour
{
    public int vidasIniciales = 10; // Número inicial de vidas
    private int vidasActuales; // Número actual de vidas
    public TextMeshProUGUI textoVidas; // Referencia al objeto TextMeshProUGUI que mostrará el número de vidas

    void Start()
    {
        vidasActuales = vidasIniciales;
        ActualizarTextoVidas();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Muerte"))
        {
            RestarVida();
        }
    }

    void RestarVida()
    {
        vidasActuales--;

        ActualizarTextoVidas();

        if (vidasActuales <= 0)
        {
            // Aquí puedo implementar cargar nuevamente la escena actual.
            ReiniciarNivel();
        }
    }

    void ActualizarTextoVidas()
    {
        // Actualiza el texto que muestra las vidas
        if (textoVidas != null)
        {
            textoVidas.text = "Vidas: " + vidasActuales.ToString();
        }
    }

    void ReiniciarNivel()
    {
        // Obtener el índice de la escena actual y cargarla nuevamente
        int indiceEscenaActual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indiceEscenaActual);
    }
}