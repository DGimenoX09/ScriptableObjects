using UnityEngine;
using UnityEngine.UI;

public class GestorIdioma : MonoBehaviour
{
    public IdiomaSO idiomaActual;

    public Text texto1;
    public Text texto2;
    public Text texto3;
    public Text texto4;

    public void CambiarIdioma(IdiomaSO nuevoIdioma)
    {
        idiomaActual = nuevoIdioma;

        texto1.text = idiomaActual.texto1;
        texto2.text = idiomaActual.texto2;
        texto3.text = idiomaActual.texto3;
        texto4.text = idiomaActual.texto4;
    }
}