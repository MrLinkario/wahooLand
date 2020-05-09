using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistemaReinicio : MonoBehaviour
{

   
    public GameObject mensajeWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "jugador")
        {
            mensajeWin.SetActive(true);
       
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
