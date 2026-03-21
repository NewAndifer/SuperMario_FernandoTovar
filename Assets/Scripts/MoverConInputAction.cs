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


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        accionMover.Enable();
        rb = GetComponent<Rigidbody2D>();
        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    void OnEnable(){
        accionSaltar.Enable();
        accionSaltar.performed += saltar;
    }

    void OnDisable(){
        accionSaltar.Disable();
        accionSaltar.performed -= saltar;
    }

    public void saltar(InputAction.CallbackContext context){
        if(estado.estaEnPiso){
            rb.linearVelocityY = velocidadY * 1;
        }
    }


    void FixedUpdate()
    {
        Vector2 movimiento = accionMover.ReadValue<Vector2>();
        rb.linearVelocityX = movimiento.x * velocidadX;
    }
}
