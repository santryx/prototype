using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDistance : MonoBehaviour
{
    //public GameObject score_Text;
    public float conteo;
    float numbScore;
    float distancia;
    //personaje personaje;
    public GameObject jugador;
    public Text score;

    void Start()
    {
        

        //score_Text.SetActive(true);
    }

    void Update()
    {

        //conteo = personaje.velocidadDeMov;


        conteo = 2 * Time.deltaTime;
        numbScore += conteo * 2;
        distancia = (int)numbScore;
        score.text = distancia.ToString("f0000000");


    }
}
