using UnityEngine;

public class MovimientoArribaAbajo : MonoBehaviour
{
    public float velocidad = 2f;
    public float distancia = 3f;

    private bool moviendoseArriba = true;
    private Vector3 posicionInicial;

    void Start()
    {
        // Guardar la posición inicial del objeto
        posicionInicial = transform.position;
    }

    void Update()
    {
        // Calcular el desplazamiento basado en la velocidad y el tiempo
        float desplazamiento = velocidad * Time.deltaTime;

        // Mover el objeto en la dirección correcta
        if (moviendoseArriba)
        {
            transform.Translate(Vector3.up * desplazamiento);
        }
        else
        {
            transform.Translate(Vector3.down * desplazamiento);
        }

        // Verificar si el objeto ha alcanzado la distancia máxima en una dirección y cambiar la dirección
        if (Mathf.Abs(transform.position.y - posicionInicial.y) >= distancia)
        {
            moviendoseArriba = !moviendoseArriba;
        }
    }
}
