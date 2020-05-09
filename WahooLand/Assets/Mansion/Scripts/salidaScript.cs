using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salidaScript : MonoBehaviour
{
    public GameObject triggerEntrada;
    public GameObject triggerSalida;
    public GameObject mensaje1;
    public GameObject mensaje2;
    public GameObject muro;
    public GameObject tiempo;

    private void OnTriggerEnter(Collider other)
    {
        triggerEntrada.SetActive(false);
        mensaje1.SetActive(false);
        mensaje2.SetActive(true);
        muro.SetActive(false);
        tiempo.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        triggerSalida.SetActive(false);
        mensaje2.SetActive(false);
        triggerEntrada.SetActive(true);
    }
}
