/*
Fernando Tovar Mejia
A01666534
21/03/2026
*/
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
    private float umbral = 0.01f; // umbral para el cambio de direccion

// Inicializacion de variables y calculo de limites
    void Start()
    {
        posXInicial = transform.position.x;
        rb = GetComponent<Rigidbody2D>();

        xMin = posXInicial - distanciaCaminada;
        xMax = posXInicial + distanciaCaminada;
    }

    void FixedUpdate()
    {
        // Actualizar posición actual antes de aplicar movimiento/comprobaciones
        posicionActual = transform.position.x;
        rb.linearVelocityX = velocidadX * direccion;
        // Comprobar si se ha alcanzado el límite derecho o izquierdo y cambiar dirección
        if(posicionActual >= xMax - umbral && direccion == 1f){
            direccion *= -1f;
        }
        else if(posicionActual <= xMin + umbral && direccion == -1f){
            direccion *= -1f;
        }

    }

}
