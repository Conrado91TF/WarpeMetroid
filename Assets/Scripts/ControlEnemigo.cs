using UnityEngine;

public class ControlEnemigo : MonoBehaviour
{
    public float velocidad;
    public Vector3 posicionFin;
    private Vector3 posicionInicio;
    private bool moviendoHaciaFin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       posicionFin = transform.position;
       moviendoHaciaFin = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Time deltaTime se usa para hacer que el movimiento sea independiente de la velocidad de fotogramas
        // == se usa para comparar dos valores
        // Vector3.MoveTowards se usa para mover un objeto hacia una posición específica
        if (moviendoHaciaFin)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionFin, velocidad * Time.deltaTime);
            if (transform.position == posicionFin)
            {
                moviendoHaciaFin = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionInicio, velocidad * Time.deltaTime);
            if (transform.position == posicionInicio)
            {
                moviendoHaciaFin = true;
            }
        }
    }
}
