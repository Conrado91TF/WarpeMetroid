using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlJugador : MonoBehaviour
{
    public int velocidad;
    private Rigidbody2D rb;
    public int FuerzaSalto;
    private SpriteRenderer sr;


    // getcomponent se usa para obtener el rigidbody2D del jugador
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

    }

    private void FixedUpdate()
    {
        // Input.GetAxis se usa para obtener el movimiento del jugador
        // Vector2 se usa para crear un vector 2D con el movimiento del jugador
        // AddForce se usa para aplicar una fuerza al rigidbody2D del jugador
        // new Vector2 significa que se crea un nuevo vector 2D
        // movimientoX se usa para almacenar el valor del movimiento horizontal del jugador
        // rb.linearVelocity se usa para establecer la velocidad lineal del rigidbody2D del jugador
        // rb.linearVelocity.y se usa para mantener la velocidad vertical del jugador
        float movimientoX = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(movimientoX * velocidad, rb.linearVelocity.y);


    }
    private void Update()
    {
        SaltoDelJugador();
    }
    private void SaltoDelJugador()
    {
        // Input.GetKeyDown se usa para detectar si se ha presionado la tecla de salto
        // KeyCode.Space se usa para detectar la tecla de espacio
        // rb.AddForce se usa para aplicar una fuerza al rigidbody2D del jugador
        // && se usa para indicar que ambas condiciones deben ser verdaderas
        // && significa "y" lógico
        if (Input.GetKeyDown(KeyCode.Space) && EstaEnSuelo())
        {
            rb.AddForce(Vector2.up * FuerzaSalto, ForceMode2D.Impulse);


        }
        // Otra forma de voltear el sprite del jugador según la dirección del movimiento
        // flipX se usa para voltear el sprite del jugador horizontalmente
        // Otra forma de poner el codigo más corto es if (rb.velocity.x > 0) sr.flipX = false;
        // else if (rb.velocity.x < 0) sr.flipX = true;
        if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = true;
        }
    }
    private bool EstaEnSuelo()
    {
        // Physics2D.Raycast se usa para detectar si el jugador está en el suelo
        // RaycastHit2D se usa para almacenar el resultado del raycast
        // transform.position se usa para obtener la posición del jugador
        // Vector2.down se usa para indicar la dirección del raycast (hacia abajo)
        // return toca.collider != null se usa para devolver true si el raycast ha tocado un collider
        // return significa que se devuelve un valor
        // != significa diferente de
        // null significa que no hay ningún valor
        // new Vector3(0, -2f, 0) se usa para ajustar el punto de origen del raycast hacia abajo
        // new Vector3 significa que se crea un nuevo vector 3D
        RaycastHit2D toca = Physics2D.Raycast(transform.position + new Vector3(0, -2f, 0), Vector2.down, 0.2f);
        return toca.collider != null;
    }
    public void ReiniciarJugador()
    {
        // SceneManager.LoadScene se usa para recargar la escena actual
        // SceneManager.GetActiveScene().name se usa para obtener el nombre de la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

