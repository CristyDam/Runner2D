using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Atributos
    //Fuerza de salto
    public float jumpForce = 10f;

    //Velocidad Horizontal del player
    public float speed = 5f;

    //Acceso al componente RigidBody2D
    private Rigidbody2D myRigidbody2D;

    public Manager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // Enlaza con el componente en tiempo de ejecucion
        myRigidbody2D = GetComponent<Rigidbody2D>();

        //Busca un GameObject que tenga un componente de tipo GameManager
        gameManager = FindObjectOfType<Manager>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //La velocidad que le aplicamos al componente vertical es playerJumForce
            myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, jumpForce);
        }

        //Ahora establecemos un valor para la velocidad horizontal(coordenada x)
        myRigidbody2D.velocity = new Vector2(speed, myRigidbody2D.velocity.y);
        
    }

    //Se llama cuando player colisiona con cualquier objeto con la propiedad collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            Debug.Log("Gana 10 puntos");
            Destroy(collision.gameObject);
            gameManager.AddScore(10);
        }
        else if (collision.CompareTag("Item2"))
        {
            Debug.Log("Gana 5 punto");
            Destroy(collision.gameObject);
            gameManager.AddScore(5);
        }
        else if (collision.CompareTag("ItemBad"))
        {
            Debug.Log("Pierdes Vidas!!");
            Destroy(collision.gameObject);
            gameManager.AddScore(-2);
        }
        else if (collision.CompareTag("DeathZone"))
        {
            Debug.Log("Muertoooo!!");

            PlayerDead();
        }
    
    }

    void PlayerDead()
    {
        SceneManager.LoadScene("level2");
    }

   
}
