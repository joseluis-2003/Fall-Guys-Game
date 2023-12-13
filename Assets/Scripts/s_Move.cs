using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Move : MonoBehaviour
{
    public float speed;
    public float angularSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Comienzo del juego");
    }

    // Update is called once per frame
    void Update()
    {
        // Invertir la dirección en las entradas de teclado
        float horizontalInput = -Input.GetAxis("Horizontal");
        float verticalInput = -Input.GetAxis("Vertical");

        transform.Translate(
            horizontalInput * speed * Time.deltaTime,
            0,
            verticalInput * speed * Time.deltaTime, Space.World);

        // Invertir la dirección en la rotación
        transform.Rotate(0, 0, horizontalInput * angularSpeed * Time.deltaTime, Space.World);
        transform.Rotate(verticalInput * angularSpeed * Time.deltaTime, 0, 0, Space.World);
    }
}
