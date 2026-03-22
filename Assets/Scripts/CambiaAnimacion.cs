/*
Fernando Tovar Mejia
A01666534
21/03/2026
*/
using UnityEngine;
using System;

public class CambiaAnimacion : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private EstadoPersonaje estado;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        estado = GetComponentInChildren<EstadoPersonaje>();  
    }

    void Update()
    {
        animator.SetFloat("velocidad", MathF.Abs(rb.linearVelocityX)); 

        //Manejar el FLIP_x
        sr.flipX = rb.linearVelocityX < 0.1;

        //Manejar animación de salto
        animator.SetBool("enPiso", estado.estaEnPiso);
    }
}
