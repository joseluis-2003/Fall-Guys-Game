using UnityEngine;

public class ReproducirSonido : MonoBehaviour
{
    public AudioClip sonido; // Asigna tu archivo de sonido aquí
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // Si no hay un componente AudioSource, agrégalo
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto que ha colisionado tiene el tag "Player"
        if (collision.collider.CompareTag("Player"))
        {
            // Reproduce el sonido cuando el jugador toca el objeto
            ReproducirEfectoSonido();
        }
    }

    void ReproducirEfectoSonido()
    {
        if (sonido != null && audioSource != null)
        {
            // Asigna el clip de sonido al AudioSource y reprodúcelo
            audioSource.clip = sonido;
            audioSource.Play();
        }
    }
}