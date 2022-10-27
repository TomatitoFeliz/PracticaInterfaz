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
    GameObject regresar;
    [SerializeField]
    GameObject logoafter;
    [SerializeField]
    GameObject image;

    private void Start()
    {
        LeanTween.scale(image, Vector3.one, 1.0f).setEaseSpring();
    }

    public void menuidiomas()
    {
        menu.SetActive(false);
        logoafter.SetActive(false);
        idiomas.SetActive(true);
    }
    public void regreso()
    {
        menu.SetActive(true);
        logoafter.SetActive(true);
        idiomas.SetActive(false);
    }

    //private void OnEnable()
    //{
    //    LeanTween.scale(image, Vector3.one, 1.0f).setEaseSpring();
    //}
}
