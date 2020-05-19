using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{

    [Range(-9,9)] public float value;
    public int fuerzaDeSaltos;
    public int velocidadDeMov = 10;
    bool canJump;

    void Start()
    {
        
    }


    void Update()
    {
        transform.position = new Vector3(value, transform.position.y, transform.position.z);
         
        this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, this.GetComponent<Rigidbody>().velocity.y, velocidadDeMov);

        if (Input.GetKeyDown("space")  && canJump)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerzaDeSaltos, 0));
            
        }

        if (Input.GetKeyDown("right"))
        {
            if (value == 9)

                return;
            value += 9;

            //this.GetComponent<Rigidbody>().velocity = new Vector3(-15, 0, 0);
            // transform.position = new Vector3(-3, transform.position.y, transform.position.z);
            //StartCoroutine("parardeliz");
        }


        if (Input.GetKeyDown("left"))
        {

            if (value == -9)

                return;
            value -= 9;
            // this.GetComponent<Rigidbody>().velocity = new Vector3(15, 0, 0);
            //transform.position = new Vector3(3, transform.position.y, transform.position.z);
            //StartCoroutine("parardeliz");
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


    /*IEnumerator parardeliz() 
    {
        yield return new WaitForSeconds(0.8f);
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }
    */


}



