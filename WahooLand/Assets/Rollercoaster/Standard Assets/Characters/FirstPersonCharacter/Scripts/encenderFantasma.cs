using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encenderFantasma : MonoBehaviour
{
    public GameObject fantasma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "jugador")
        {
            fantasma.GetComponent<calamardo>().encendido = 1;
        }
    }
}
