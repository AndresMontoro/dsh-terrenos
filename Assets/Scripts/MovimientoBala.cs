using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public float velocidad = 5.0f;
    public float valorHerida = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movDistancia = velocidad * Time.deltaTime;
        transform.Translate(Vector3.left * movDistancia);
    }
}
