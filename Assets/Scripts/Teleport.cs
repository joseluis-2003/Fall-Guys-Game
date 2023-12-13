using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que colisiona tiene el tag "player".
        if (other.CompareTag("Player"))
        {
            // Teletransportar al personaje al punto de respawn.
            other.transform.position = respawnPoint.position;
        }
    }
}