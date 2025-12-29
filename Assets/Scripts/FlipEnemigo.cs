using UnityEngine;

public class FlipEnemigo : MonoBehaviour
{
    private SpriteRenderer sr;
    private float direccionAnterior;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void Start()
   {
        direccionAnterior = transform.parent.position.x;
        sr = GetComponent<SpriteRenderer>();
   }

    // Update is called once per frame
    private void Update()
    {
        // movimiento hacia la derecha
        sr.flipX = direccionAnterior < transform.position.x;

        // movimiento hacia la izquierda
        direccionAnterior = transform.position.x;
    }
}
