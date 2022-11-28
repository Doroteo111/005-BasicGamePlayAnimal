using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperLimit = 20f;
    private float lowerLimit = -10f;

    private void Update()
    {
        //LIMITE INFERIOR-> ANIMALES NO ALIMENTADOS
        if(transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }

        //LIMITE SUPERIOR-> BALA FALLIDA
        if (transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
