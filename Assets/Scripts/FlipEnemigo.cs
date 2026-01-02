using UnityEngine;

public class FlipEnemigo : MonoBehaviour
{
    private SpriteRenderer sr;
    private float direccionAnteriorX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void Start()
   {
        direccionAnteriorX = transform.parent.position.x;
        sr = GetComponent<SpriteRenderer>();
   }

    // Update is called once per frame
    private void Update()
    {
        // movimiento hacia la derecha
        sr.flipX = direccionAnteriorX < transform.position.x;

        // movimiento hacia la izquierda
        direccionAnteriorX = transform.position.x;
    }
}
