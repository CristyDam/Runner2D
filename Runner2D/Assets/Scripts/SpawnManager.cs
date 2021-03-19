using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefabs; //Array de bloques
    public float minTime = 1f;
    public float maxTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creacion de la corrutina(se ejecuta en el tiempo
    IEnumerator SpawnCoroutine(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        //Esta instancia crea un gameObject
        Instantiate(itemPrefabs[Random.Range(0, itemPrefabs.Length)], transform.position, Quaternion.identity);

        //Para que vuelva a ejecutarse la corrutina un tiempo aleatorio.
        StartCoroutine(SpawnCoroutine(Random.Range(minTime, maxTime)));
    }

}
