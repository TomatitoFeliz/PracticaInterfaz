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
    
    //Para hacerlo de forma m�s profesional con un solo c�digo:
    //public void Fill(float valor)
    //{
    //  image.fillAmount += valor;
    //}

    //Nueva funci�n que rellena +0.1f el icono
    public void Da�o()
    {
        image.fillAmount += 0.1f;
    }

    //Nueva funci�n que disminuye en -0.1f el fill del icono
    public void Cura()
    {
        image.fillAmount -= 0.1f;
    }

    

}
