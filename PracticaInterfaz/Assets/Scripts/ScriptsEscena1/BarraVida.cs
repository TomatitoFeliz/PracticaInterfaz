using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    [SerializeField]
    int healthPlayer = 5;
    [SerializeField]
    int MAX_HEALTH = 20;
    [SerializeField]
    Slider sliderhealth;
    // Start is called before the first frame update
    void Start()
    {
        sliderhealth.maxValue = MAX_HEALTH;
        //Pongan el valor del slider a la mitad de MAX_HEALTH
        //sliderhealth.value = MAX_HEALTH/2;
    }
    public void Salud(float vida)
    {
        sliderhealth.value += vida;
    } 
}
