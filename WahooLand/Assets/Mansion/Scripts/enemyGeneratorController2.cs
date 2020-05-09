using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGeneratorController2 : MonoBehaviour
{
    public GameObject jugador;
    public GameObject enemigo;
    public Transform zonaGen;
    int empezar;
    int cantidad;
    // Start is called before the first frame update
    void Start()
    {
        empezar = 0;
        cantidad = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //empezar = jugador.GetComponent<FirstPersonController>().m_WalkSpeed;
        if (empezar==1 && cantidad == 0)
        {
            Instantiate(enemigo, zonaGen.position, zonaGen.rotation);
        
        }


        if (!enemigo)
        {
            cantidad = 0;
        }
    }
}
