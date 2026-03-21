using UnityEngine;

public class MovimientoGoomba : MonoBehaviour
{
    private Rigidbody2D rb;
    private float posXInicial;
    private float distanciaCaminada = 2f;
    private float velocidadX = 4f;

    private float direccion = 1f;
    private float posicionActual;
    private float xMin;
    private float xMax;
    private float umbral = 0.01f;

    void Start()
    {
        posXInicial = transform.position.x;
        rb = GetComponent<Rigidbody2D>();

        xMin = posXInicial - distanciaCaminada;
        xMax = posXInicial + distanciaCaminada;

    }

    void FixedUpdate()
    {
        posicionActual = transform.position.x;
        rb.linearVelocityX = velocidadX * direccion;

        if(posicionActual >= xMax - umbral && direccion == 1f){
            direccion *= -1f;
        }
        else if(posicionActual <= xMin + umbral && direccion == -1f){
            direccion *= -1f;
        }

    }

}
