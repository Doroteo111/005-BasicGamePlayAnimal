using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float xRange = 15f; //limite pantalla
    private float speed = 10f;
    private float horizontalInput;

    public GameObject projectilePrefab;

    
    private void Update()
    {
        //movimiwnto horizontal player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime*horizontalInput);
        
        PlayerInBounds(); //mantiene al player en la pantalla

        //mecanicas del disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }
    }
   
    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;
        if (pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }

        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
    }

    private void FireProjectile()           //hace aparecer cosas en escena
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);    //el que, donde y como
    }
}
