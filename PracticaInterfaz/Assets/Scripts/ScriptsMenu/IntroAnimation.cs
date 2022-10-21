using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject logo;
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject logoafter;

    void Start()
    {
        //Oculto mi logo. De manera inmeidata, en cero segundos.
        LeanTween.moveLocalY(logo, -1590f, 0.0f);
        //Hago aparecer el logo desde su posición hasta la posición querida en el eje Y
        //animación que dura 2.0 segundos.
        //.setOnComplete(funcion) para que cuando se acabe, empieze la otra animacion
        LeanTween.moveLocalY(logo, 64f, 1.0f).setEaseInBack().setOnComplete(latido);
        //Hace un latido "escalando"
            //LeanTween.scale(logo, new Vector3(0.5f, 0.5f, 0.0f), 4.0f);
            //LeanTween.scale(logo, new Vector3(1f, 1f, 0.0f), 1.0f);

        //Para moverlo localmente en ambos ejes
        //LeanTween.moveLocal(logo, new Vector3(x, y, z), 1.5f);
    }

    void latido()
    {
        LeanTween.scale(logo, Vector3.one, 1.0f).setEaseSpring().setOnComplete( () => {
            LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Desactivar);        
        });
    }

    void Desactivar()
    {
        gameObject.SetActive(false);
        //Activar el menú principal...
        menu.SetActive(true);
        logoafter.SetActive(true);

    }
}
