using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40f; //no podemos privatizarla pq cada animal, speed diferente
    private void Update()
    {
        //mover hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
   
}
