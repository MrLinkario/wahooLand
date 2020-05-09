using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class entradaScript : MonoBehaviour
{
    public GameObject triggerEntrada;
    public GameObject triggerSalida;
    public GameObject mensaje;
    public GameObject muro;
    public Text tiempo;
    public float time = 90f;
    public  bool actTimer;
    public int actEntrada;
    public GameObject usuario;
    public bool reinicio;
    public Transform inicio;


    private void Start()
    {
        tiempo.text = "Una vez dentro del laberinto, tienes:" + time +"Segundos para salir";
        actTimer = false;
        actEntrada = 0;
        reinicio = false;
    }

    private void Update()
    {
        tiempo.text = "Quedan" + time.ToString("f0") + "segundos";
        if (actTimer == true) {

            if (time >= 0) {

                
                time -= Time.deltaTime;
            }
            else
            {
                time = 0;
                triggerSalida.SetActive(false);
                mensaje.SetActive(true);
                muro.SetActive(true);

            }
        }

        if (reinicio)
        {
            usuario.transform.position = inicio.transform.position;
            time = 90;
            actTimer = false;
            actEntrada = 0;
            reinicio = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "jugador")
        {
            if (actEntrada == 0)
            {

                //triggerSalida.SetActive(true);
                //muro.SetActive(true);
                actTimer = true;
                actEntrada = 1;
            }
        }
        
    }

    private void lose()
    {
        //triggerSalida.SetActive(false);
        //usuario.GetComponent<FirstPersonController>().reinicio=true;

        actTimer = false;
        time = 90;
        actEntrada = 0;
        reinicio = true;


    }

    public void reinicioLab()
    {
        SceneManager.LoadScene(1);
    }
}
