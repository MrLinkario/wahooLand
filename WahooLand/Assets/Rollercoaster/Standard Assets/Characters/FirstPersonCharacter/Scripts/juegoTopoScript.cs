using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class juegoTopoScript : MonoBehaviour
{
    //variables tiempo
    public float timeDisponible;
    float time;
    int active;
    
    //variables de los tubos
    public GameObject tubo1;
    public GameObject tubo2;
    public GameObject tubo3;
    public GameObject tubo4;

    //score
    public int puntaje; 

    //los canvas
    public Text tiempo;
    public Text puntos;
    public GameObject menu1;
    public GameObject menu2;
    public Text puntosFinales;




    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        active = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == 1)
        {
            if (time > 0)
            {
                tiempo.text = "Quedan" + time.ToString("f0") + "segundos";
                puntos.text = "Puntos:" + puntaje;
                time -= Time.deltaTime;
            }
            else
            {
                time = 0;
                menu2.SetActive(true);
                puntosFinales.text = "Tu puntaje final es:" + puntaje + "\n" + "¿Quiere jugar de nuevo?";
                tubo1.GetComponent<enemyGeneratorController>().empezar = 0;
                tubo2.GetComponent<enemyGeneratorController>().empezar = 0;
                tubo3.GetComponent<enemyGeneratorController>().empezar = 0;
                tubo4.GetComponent<enemyGeneratorController>().empezar = 0;
            }
        }
    }

    public void empezar()
    {
        time = timeDisponible;
        puntaje = 0;
        active = 1;
        tubo1.GetComponent<enemyGeneratorController>().empezar = 1;
        tubo2.GetComponent<enemyGeneratorController>().empezar = 1;
        tubo3.GetComponent<enemyGeneratorController>().empezar = 1;
        tubo4.GetComponent<enemyGeneratorController>().empezar = 1;
        menu1.SetActive(false);
        menu2.SetActive(false);
    }

    public void irAOtroLado()
    {
        SceneManager.LoadScene(0);
    }
}
