using UnityEngine.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private UIDocument menu;
    private Button BotonJugar;
    private Button BotonAyuda;
    private Button BotonCreditos;
    private Button BotonSalir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        BotonJugar = root.Q<Button>("BotonJugar");
        BotonAyuda = root.Q<Button>("BotonAyuda");
        BotonCreditos = root.Q<Button>("BotonCreditos");
        BotonSalir = root.Q<Button>("BotonSalir");

        BotonJugar.clicked += abrirJugar;
        BotonAyuda.clicked += abrirAyuda;
        BotonCreditos.clicked += abrirCreditos;
        BotonSalir.clicked += abrirSalir;

    }
    private void abrirJugar()
    {
        SceneManager.LoadScene("Juego");
    }

    private void abrirAyuda()
    {
        SceneManager.LoadScene("Ayuda");
    }

    private void abrirCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    private void abrirSalir()
    {
        Application.Quit();
    }

    void OnDisable()
    {
         BotonJugar.clicked -= abrirJugar;

        
    }
}
