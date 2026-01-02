using UnityEngine;
using TMPro;

public class ControlHUD : MonoBehaviour
{
    public TextMeshProUGUI textoVidas;
    public TextMeshProUGUI textoTiempo;
    public TextMeshProUGUI textoEferas;

    //setvidasTxt se utiliza para actualizar el texto de las vidas en el HUD
    // Tostring convierte el entero vidas a una cadena de texto y la concatena con "Vidas: "

    public void setVidasTxt(int vidas)
    {
        textoVidas.text = "Vidas:" + vidas;
    }
    public void setTiempoTxt(int tiempo)
    {
        int segundos = tiempo % 60;
        int minutos = tiempo / 60;
        textoTiempo.text = minutos.ToString("00") + ":" + segundos.ToString("00");
    }
    public void setEsferasTxt(int esferas)
    {
        textoEferas.text = "Esferas:" + esferas;
    }

}
