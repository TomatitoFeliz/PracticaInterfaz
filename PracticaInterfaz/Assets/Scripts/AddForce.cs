using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField]
    Vector3 fuerza;

    //Para a�adirle fuerzas a un cuerpo f�sico creamos un Rigidbody
    Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    public void AddForces()
    {
        body.AddForce(fuerza, ForceMode.Impulse);
    }

    public void AddForces(Vector3 parametro)
    {
        body.AddForce(parametro, ForceMode.Impulse);
    }
}
