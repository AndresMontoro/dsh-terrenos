using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorDisparos : MonoBehaviour
{
    Transform salidaBala;
    float proximoDisparo = 0f;
    float tiempoEspera = 0.3f;
    public GameObject bala;

    void Start()
    {
        salidaBala = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= proximoDisparo && Input.GetMouseButtonDown(0))
        {
            proximoDisparo = Time.time + tiempoEspera;
            Debug.Log("1- He disparado");
            GameObject nuevaBala = Instantiate(bala, salidaBala.position, salidaBala.rotation);
        }
        
    }
}
