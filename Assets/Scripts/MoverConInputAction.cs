/*
Fernando Tovar Mejia
A01666534
21/03/2026
*/
using UnityEngine;
using UnityEngine.InputSystem;

public class MoverConInputAction : MonoBehaviour
{
    [SerializeField]
    private InputAction accionMover;
    [SerializeField]
    private InputAction accionSaltar; 
    private float velocidadX = 5f;
    private float velocidadY = 6f;

    private Rigidbody2D rb;
    private EstadoPersonaje estado;

    void Start()
    {
        // Habilitamos la acción de movimiento y obtenemos componentes requeridos
        accionMover.Enable();
        rb = GetComponent<Rigidbody2D>();
        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    void OnEnable(){
        accionSaltar.Enable();
        accionSaltar.performed += saltar;
    }

    void OnDisable()
    {
        // Deshabilitar la acción al desactivar el componente
        accionSaltar.performed -= saltar;
        accionSaltar.Disable();
    }

    public void saltar(InputAction.CallbackContext context){
        if(estado.estaEnPiso){
            rb.linearVelocityY = velocidadY * 1;
        }
    }

    void FixedUpdate()
    {
        // Leer entrada de movimiento y aplicar velocidad horizontal
        Vector2 movimiento = accionMover.ReadValue<Vector2>();
        rb.linearVelocityX = movimiento.x * velocidadX;
    }
}
