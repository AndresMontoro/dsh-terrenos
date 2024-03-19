using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaZombie : MonoBehaviour
{
    public float vida = 100.0f;
    
    void Update ()
    {
        if (vida <= 0)
            Destroy(gameObject);
    }

}
