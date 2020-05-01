using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class calamardo : MonoBehaviour
{

    public Transform objetivo;
    private NavMeshAgent agente;

    // Start is called before the first frame update
    void Start()
    {
        agente = this.GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = objetivo.position;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(this.gameObject);
        }

        if (other.tag == "jugador")
        {
            Destroy(this.gameObject);
        }
    }
}
