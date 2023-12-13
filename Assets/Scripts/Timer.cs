using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    // Update is called once per frame
    void Update()
    {
        // Si aún queda tiempo en el temporizador, decrementa el tiempo restante.

        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        // Si el tiempo restante es menor que cero, establece el tiempo restante a cero, cambia el color del texto a rojo
        // y recarga la escena actual.
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;
            int indiceEscenaActual = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(indiceEscenaActual);
        }
        remainingTime -= Time.deltaTime;
        // Calcula los minutos y segundos a partir del tiempo restante.
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        // Formatea el tiempo en minutos y segundos y lo muestra en el TextMeshProUGUI.

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
