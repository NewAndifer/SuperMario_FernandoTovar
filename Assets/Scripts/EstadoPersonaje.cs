/*
Fernando Tovar Mejia
A01666534
21/03/2026
*/
using UnityEngine;

public class EstadoPersonaje : MonoBehaviour
{
    //Detecta si el personaje está en el suelo usando un Collider2D marcado como trigger
     
    public bool estaEnPiso { get; private set; } = false;

    void Start(){
        print("Inicia EstadoPersonaje");
    }

    void OnTriggerEnter2D(Collider2D collision){
        estaEnPiso = true;
        print(estaEnPiso);
    }

    void OnTriggerExit2D(Collider2D collision){
        estaEnPiso = false;
        print(estaEnPiso);
    }
}
