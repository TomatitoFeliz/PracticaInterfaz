using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuIdiomas : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject idiomas;
    [SerializeField]
    GameObject logoafter;
    [SerializeField]
    GameObject image;
    [SerializeField]
    GameObject bandera;

    private void OnEnable()
    {
        LeanTween.scale(image, Vector3.zero, 0.0f);
        LeanTween.scale(image, Vector3.one, 1.0f).setEaseSpring();
    }

    public void menuidiomas()
    {
        menu.SetActive(false);
        bandera.SetActive(false);
        logoafter.SetActive(false);
        idiomas.SetActive(true);
    }

    public void cerrar()
    {
        LeanTween.scale(image, Vector3.zero, 0.5f).setOnComplete(() => {
            menu.SetActive(true);
            bandera.SetActive(true);
            logoafter.SetActive(true);
            idiomas.SetActive(false);
        }); 
    }

    //private void OnEnable()
    //{
    //    LeanTween.scale(image, Vector3.one, 1.0f).setEaseSpring();
    //}
}
