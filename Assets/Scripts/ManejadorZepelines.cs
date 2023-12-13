using UnityEngine;

public class ZeppelinController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject zeppelinPrefab;
    public GameObject destructorObject;

    private void Update()
    {
        // Mueve el Zeppelin hacia adelante en el eje Z
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Instancia un nuevo Zeppelin en la posición del objeto vacío (Destructor) y lo mueve en el eje X
            GameObject newZeppelin = Instantiate(zeppelinPrefab, destructorObject.transform.position, Quaternion.identity);

            // Ajusta la dirección del movimiento al eje X
            newZeppelin.GetComponent<ZeppelinController>().MoveOnX();

            // Destruye el Zeppelin actual
            Destroy(gameObject);
        }
    }

    // Métod para ajustar la dirección del movimiento al eje X
    private void MoveOnX()
    {
        // Cambia la dirección del movimiento al eje X
        speed = 8f;
        transform.rotation = Quaternion.Euler(0f, -90f, 90f); // Ajusta la rotación si es necesario
    }
}




