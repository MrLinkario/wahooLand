using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGeneratorController : MonoBehaviour
{
    public Transform jugador;
    public GameObject enemigo;
    private GameObject hijo;
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
        if (cantidad == 0)
        {
           hijo= Instantiate(enemigo, zonaGen.position, zonaGen.rotation);
            hijo.GetComponent<calamardo>().objetivo = jugador;
            cantidad = 1;

        }




        if (!hijo)
        {
            cantidad = 0;
        }
    }
}