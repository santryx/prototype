using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaramanager : MonoBehaviour
{
    public GameObject jugador;
    public Camera camaraDelJuego;
    
    public GameObject[] mundoPrefab;
    public float pJuego;
    public float lugarseguro = 2;

 


    void Start()
    {
        pJuego = -7;
        
    }

   
    void Update()
    {
       

        if (jugador != null)
        {
            camaraDelJuego.transform.position = new Vector3(camaraDelJuego.transform.position.x, camaraDelJuego.transform.position.y, camaraDelJuego.transform.position.z);
          
        }

        while (jugador != null && pJuego < jugador.transform.position.z + lugarseguro) 
        {
            int indiceMundo = Random.Range(0, mundoPrefab.Length - 1);

            if (pJuego < 0)
            {
                indiceMundo = 2;
            }

            GameObject ObjetoMundo = Instantiate(mundoPrefab[indiceMundo]);
            ObjetoMundo.transform.SetParent(this.transform);
            Mundo mundo = ObjetoMundo.GetComponent<Mundo>();
            ObjetoMundo.transform.position = new Vector3(0, 0,  pJuego + mundo.tamaño / 2);
            pJuego += mundo.tamaño;
        }
        
    }

}
