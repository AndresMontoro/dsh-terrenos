using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigosMovimiento : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent pathfinder;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        pathfinder = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Hay que actualizar cada cierto tiempo y guardar distancia de seguridad
        pathfinder.SetDestination(target.position);
    }
}
