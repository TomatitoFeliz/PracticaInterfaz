using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeMuere : MonoBehaviour
{
    [SerializeField]
    GameObject jugador;

    [SerializeField]
    Image imagen;

    private void Start()
    {
        imagen.GetComponent<Image>();
    }
    private void Update()
    {
        for (imagen.fillAmount = 1.0f; ;)
        {
            jugador.SetActive(false);
        }
    }


}
