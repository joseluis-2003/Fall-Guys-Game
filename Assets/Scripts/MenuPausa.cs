using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    // Este métod pausa el juego al establecer el Time.timeScale en 0.
    // También desactiva el botón de pausa y activa el menú de pausa.
    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    // Este métod reanuda el juego al restablecer el Time.timeScale a 1.
    // También activa el botón de pausa y desactiva el menú de pausa.
    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    // Este métod reinicia la escena actual al cargarla de nuevo.
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Este métod cierra la aplicación en el editor de Unity.

    public void Cerrar()
    {
        Debug.Log("Cerrando Juego");
        SceneManager.LoadScene("MenuInical");

    }
    //Este métod carga la escena del menú principal.
    public void CargarMenuPrincipal()
    {
        SceneManager.LoadScene("MenuInical");
    }

}
