using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);  //destruye proyectil
        Destroy(other.gameObject);  //destruye animal con el que colisiono

    }
}
