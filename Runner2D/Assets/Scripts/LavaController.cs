using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaController : MonoBehaviour
{
    //Atributos 
    private bool derecha;
    public GameObject cam;
    private float movingSpeed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        derecha = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > cam.transform.position.x + 1)
            derecha = false;
        if (transform.position.x < cam.transform.position.x - 1)
            derecha = true;

        if(derecha)
            transform.position = new Vector3(transform.position.x + movingSpeed, transform.position.y, transform.position.z);
        else
            transform.position = new Vector3(transform.position.x - movingSpeed, transform.position.y, transform.position.z);

    }
}
