using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Introduccion : MonoBehaviour
{
    [SerializeField]
    GameObject gameplay, intro, player;
    [SerializeField]
    TMP_InputField inputnombre;
    [SerializeField]
    TextMeshProUGUI nombre;

    void Start()
    {
        gameplay.SetActive(false);
        intro.SetActive(true);
        player.SetActive(false);
    }


    public void Play()
    {
        nombre.text = inputnombre.text;
        player.SetActive(true);
        gameplay.SetActive(true);
        intro.SetActive(false);
        Debug.Log(inputnombre.text);
    }
}
