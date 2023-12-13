using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
   public void jugar()
    {
        // Obtiene el índice de construcción de la escena activa y carga la siguiente escena.

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void salir()
    {
        Debug.Log("Salir....");
        // Cierra la aplicación.
        Application.Quit();
    }
}
