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

        BotonJugar.clicked += abrirJugar;


    }
    private void abrirJugar()
    {
        SceneManager.LoadScene("Juego");
    }

    void OnDisable()
    {
         BotonJugar.clicked -= abrirJugar;
        
    }
}
