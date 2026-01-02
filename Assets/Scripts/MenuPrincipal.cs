using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void OnBotonJugar()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void OnBotonSalir()
    {
        Application.Quit();
        Debug.Log("Salir del juego");
    }
    public void OnBotonCredictos()
    {
        SceneManager.LoadScene("Credictos");
    }
    public void OnBotonVolver()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

}
