using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Changelenguage : MonoBehaviour
{
    int idioma = 0;
    //void Awake()
    //{
        //Array copn los diferentes idiomas que tiene el juego configurado
        //LocalizationSettings.AvailableLocales.Locales
        //Idiomas = (Español, Inglés, Aleman, Francés, Italiano,...);

        //El idioma que se está utilizando
        //LocalizationSettings.SelectedLocale

        //int idiomaAleatorio = Random.Range(0, 4); //Genero número aleatorio
        //LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaAleatorio];
        //¿Le da límite al array? ¿Me dice los idiomas que hay?
        //int langAvailables = LocalizationSettings.AvailableLocales.Locales.Count;
    //}

    //Función Next Language
    public void Next()
    {
        Debug.Log("Click on Next");
        idioma++;
        if (idioma == LocalizationSettings.AvailableLocales.Locales.Count)
        {
            idioma = 0;
            Debug.Log("Reinicio cuenta");
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idioma];
    }

    //Función Previous Language
    public void Previous()
    {
        Debug.Log("Click on Previous");
        idioma--;
        if (idioma == -1)
        {
            idioma = 4;
            Debug.Log("Reinicio Contrario");
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idioma];
    }


}
