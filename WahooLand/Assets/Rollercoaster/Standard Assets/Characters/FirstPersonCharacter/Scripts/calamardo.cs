using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class calamardo : MonoBehaviour
{

    public Transform objetivo;
    private NavMeshAgent agente;
    public GameObject entrada;
    public int encendido=0;

    // Start is called before the first frame update
    void Start()
    {
        agente = this.GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (encendido == 1)
        {
             agente.destination = objetivo.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.tag == "jugador")
        {
            entrada.GetComponent<entradaScript>().time -= 10;
            Destroy(this.gameObject);
        }
    }
}
