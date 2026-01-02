using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int cantidad;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            collision.gameObject.GetComponent<ControlJugador>().SumarPuntos(cantidad);
            Destroy(gameObject);

        }
    }
}
