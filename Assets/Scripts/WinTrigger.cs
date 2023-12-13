using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    // Referencia al objeto de texto que se mostrará cuando el jugador gane.
    public GameObject youwinText;
    public float delay;

    // Update is called once per frame
    void Start ()
    {
        // Desactiva el texto "You Win" al inicio.
        youwinText.SetActive(false);
    }
    // Se llama cuando otro objeto con un Collider entra en el área del Collider de este objeto.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            youwinText.SetActive(true);
            StartCoroutine(Countdown());
            
        }

    }

    // Rutina de conteo regresivo utilizando corutinas de Unity.

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(delay);
       
    }
    // Métod para reiniciar la escena actual.
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //Metod para cerrar
    public void Cerrar()
    {
        SceneManager.LoadScene("MenuInical");
    }

}
