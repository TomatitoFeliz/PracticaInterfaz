using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoAfter : MonoBehaviour
{
    [SerializeField]
    GameObject logoafter;

    private void OnEnable()
    {
        LeanTween.scale(logoafter, new Vector3(0.5948593f, 0.5948593f, 0.5948593f), 2.0f).setEaseSpring();
        LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 1.0f, 2.0f);
    }

}
