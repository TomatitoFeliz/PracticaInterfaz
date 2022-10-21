using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioMenu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;


    private void OnEnable()
    {
        LeanTween.moveLocalX(menu, -569, 1.0f).setEaseInOutBounce();
    }

}
