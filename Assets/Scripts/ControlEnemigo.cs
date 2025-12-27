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
       MoverEnemigo();

    }
    private void MoverEnemigo()
    {
        //Time deltaTime se usa para hacer que el movimiento sea independiente de la velocidad de fotogramas
        // == se usa para comparar dos valores
        // Vector3.MoveTowards se usa para mover un objeto hacia una posición específica
        // ? operador ternario para elegir entre dos valores
        
        Vector3 posicionDestino = (moviendoHaciaFin) ? posicionFin : posicionInicio;
        transform.position = Vector3.MoveTowards(transform.position, posicionDestino, velocidad * Time.deltaTime);

        if (transform.position == posicionFin)
        {
            moviendoHaciaFin = false;
        }
        if (transform.position == posicionInicio)
        {
            moviendoHaciaFin = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
           collision.gameObject.GetComponent<ControlJugador>().ReiniciarJugador();
        }
    }
}

