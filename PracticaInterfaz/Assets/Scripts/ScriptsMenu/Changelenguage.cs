using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Changelenguage : MonoBehaviour
{
    int idioma = 0;
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

    //Funci�n Previous Language
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

//----------------------------------------------------------------------------------------------------------------------------------------

    //private void Start()
    //{
        //SelectCurrentLang();
    //}
    //void SelectCurrentLang()
    //{
    //UnityEngine.Localization.Locale searcher = LocalizationSettings.AvailableLocales.Locales[idioma];

    //Mientras el idioma que est� funcionando no es el que estoy revisando, miro el siguiente.
    //while (searcher != LocalizationSettings.SelectedLocale && idioma < LocalizationSettings.AvailableLocales.Locales.Count)
        //{
            //idioma++;
            //searcher = LocalizationSettings.AvailableLocales.Locales[idioma];
        //}

    //}

//-----------------------------------------------------------------------------------------------------------------------------------------

    //void Awake()
    //{
    //Array copn los diferentes idiomas que tiene el juego configurado
    //LocalizationSettings.AvailableLocales.Locales
    //Idiomas = (Espa�ol, Ingl�s, Aleman, Franc�s, Italiano,...);

    //El idioma que se est� utilizando
    //LocalizationSettings.SelectedLocale

    //int idiomaAleatorio = Random.Range(0, 4); //Genero n�mero aleatorio
    //LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaAleatorio];
    //�Le da l�mite al array? �Me dice los idiomas que hay?
    //int langAvailables = LocalizationSettings.AvailableLocales.Locales.Count;
    //}

    //Funci�n Next Language
 

}
