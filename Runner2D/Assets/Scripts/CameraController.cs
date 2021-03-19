using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Declara una variable al cual enfocara la camara y que sera el personaje.
     public Transform targetPlayer;

    // Start is called before the first frame update
    void Start()
    {
        // Si no esta asignado en el inspector
        if (targetPlayer == null)
            {
            // Se asigna ...
            targetPlayer = GameObject.FindGameObjectWithTag("Player"). transform ;
        }

    }

    // Update is called once per frame
    void Update()
    {
        // La camara siempre trabaja en 3 dimensiones , por eso necesitamos un Vector3.
        transform.position = new Vector3(targetPlayer.position.x + 6f, 0, -10);
 
    }
}
