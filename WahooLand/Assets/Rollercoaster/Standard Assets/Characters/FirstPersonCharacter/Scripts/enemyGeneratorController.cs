using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGeneratorController : MonoBehaviour
{
    public GameObject enemigo;
    private GameObject hijo;
    public Transform zonaGen;
    public GameObject patron;

    public float timeRespawn;
    public float time;
    int f;

    public int empezar;
    public int cantidad;
    // Start is called before the first frame update
    void Start()
    {
        //empezar = 0;
        //cantidad = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //empezar = jugador.GetComponent<FirstPersonController>().m_WalkSpeed;
        if (empezar == 1) { 
            if (cantidad == 0)
            {
                if (time > 0)
                {
                    time -= Time.deltaTime;
                }
                else
                {
                    hijo = Instantiate(enemigo, zonaGen.position, zonaGen.rotation);
                    hijo.GetComponent<salmonsitoScript>().gameManager = patron;
                    //hijo.GetComponent<calamardo>().objetivo = jugador;
                    cantidad = 1;
                    f = 0;
                }

            }




        if (!hijo)
        {

            if (f== 0)
            {
                cantidad = 0;
                time = timeRespawn;
                    f = 1;
            }

        }
    }
    }
}