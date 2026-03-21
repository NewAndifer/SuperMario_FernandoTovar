using UnityEngine;
using UnityEngine.InputSystem;

public class MoverConInputAction : MonoBehaviour
{
    [SerializeField]
    private InputAction accionMover;
    [SerializeField]
    private InputAction accionSaltar; 
    private float velocidadX = 5f;
    private float velocidadY = 5f;

    private Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        accionMover.Enable();
        rb = GetComponent<Rigidbody2D>();
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
        rb.linearVelocityY = velocidadY * 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = accionMover.ReadValue<Vector2>();
        
        //transform.position = (Vector2)transform.position + movimiento*velocidadX*Time.deltaTime;
        rb.linearVelocityX = movimiento.x * velocidadX;
    }
}
