using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroirLaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float tempoDeVida = 2.0f;
        Destroy(gameObject, tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
