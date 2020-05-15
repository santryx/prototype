using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{

    public int fuerzaDeSaltos;
    public int velocidadDeMov;
    bool canJump;

    void Start()
    {
        
    }


    void Update()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, this.GetComponent<Rigidbody>().velocity.y, velocidadDeMov);

        if (Input.GetKeyDown("space")  && canJump)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerzaDeSaltos, 0));
        }

        if (Input.GetKeyDown("a"))
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(-15, 0, 0);
            StartCoroutine("parardeliz");
        }


        if (Input.GetKeyDown("d"))
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
            StartCoroutine("parardeliz");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canJump = true;

        if (other.tag == "Obstaculo")
        {
            GameObject.Destroy(this);
            Debug.Log("perdiste");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canJump = false;
    }


    IEnumerator parardeliz() 
    {
        yield return new WaitForSeconds(0.8f);
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }


}



