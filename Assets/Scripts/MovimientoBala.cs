using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public float velocidad = 5.0f;
    public float valorHerida = 10.0f;
    public LayerMask capasDestruir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movDistancia = velocidad * Time.deltaTime;
        transform.Translate(Vector3.forward * movDistancia);
        CheckCollision(movDistancia);
    }

    void CheckCollision(float moveDIstancia)
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, moveDIstancia, capasDestruir, QueryTriggerInteraction.Collide))
        {
            if (hit.collider.tag == "Enemigo")
            {
                hit.transform.gameObject.GetComponent<VidaZombie>().vida -= valorHerida;
            }
            Destroy(gameObject);
        }

    }
}
