using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Muerte : MonoBehaviour
{
    Image image;

    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 0.5f;
    }
    
    //Para hacerlo de forma más profesional con un solo código:
    //public void Fill(float valor)
    //{
    //  image.fillAmount += valor;
    //}

    //Nueva función que rellena +0.1f el icono
    public void Daño()
    {
        image.fillAmount += 0.1f;
    }

    //Nueva función que disminuye en -0.1f el fill del icono
    public void Cura()
    {
        image.fillAmount -= 0.1f;
    }

    

}
