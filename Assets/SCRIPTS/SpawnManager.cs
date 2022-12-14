using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //array de animales
    private int animalIndex; //indice del array

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) //QUE TECLA PULSAR
        {
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 15), animalPrefabs[animalIndex].transform.rotation);
        }
    }*/ //LIMPIAMOS ESTO CON LA FUNCI?N DE ABAJO

    private float spawnRangeX = 14f;
    private float spawnPosZ = 15f;

    private float startDelav = 1.5f; //tiempo para el jugador se prepare
    private float spawnInterval = 2f; //tiempo que tarde en aparecer otro animal

    private void Start()
    {
        //llama periodicamente a la funcion SpawnRandomAnimal
        InvokeRepeating("SpawnRandomAnimal", startDelav, spawnInterval);
    }

   
    private void SpawnRandomAnimal()  //funci?n privada no devuelve, aparece animal aleatorio posici?n
    {
        animalIndex = Random.Range(0, animalPrefabs.Length); // generamos indice aleatorio
        Instantiate(animalPrefabs[animalIndex], 
            RandomSpawnPos()     //llamar a la funci?n, genera un vector aleatorio (solo cordenada x)
            , animalPrefabs[animalIndex].transform.rotation);
    }

    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosZ);
    }
}
