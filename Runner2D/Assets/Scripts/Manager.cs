using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private int playerScore = 0;

    // atributo publico para que aparezca en el inspector(LAbel de la capaUI)
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void AddScore(int valor)
    {
        playerScore += valor;
        Debug.Log("Puntuacion : " + playerScore);
        scoreText.text = playerScore.ToString();

    }
}
