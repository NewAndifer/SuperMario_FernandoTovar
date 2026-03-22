/*
Fernando Tovar Mejia
A01666534
21/03/2026
*/
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Regresa : MonoBehaviour
{
    private UIDocument menu;
    private Button botonRegresar;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        botonRegresar = root.Q<Button>("BotonRegresar");
        botonRegresar.clicked += CerrarEscena;
    }

    private void CerrarEscena()
    {
        SceneManager.LoadScene("EscenaMenu");
    }
    
    void OnDisable()
    {
        botonRegresar.clicked -= CerrarEscena;
    }
}