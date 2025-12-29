using UnityEngine;

public class EfectoParallax : MonoBehaviour
{
    public float velocidadParallax;

    private Transform camaraTransform;
    private Vector3 posicionAnteriorCamara;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camaraTransform = Camera.main.transform;
        posicionAnteriorCamara = camaraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movimientoFondo = camaraTransform.position - posicionAnteriorCamara;
        transform.position += new Vector3(movimientoFondo.x * velocidadParallax, movimientoFondo.y * velocidadParallax, 0);
        posicionAnteriorCamara = camaraTransform.position;
    }
}
