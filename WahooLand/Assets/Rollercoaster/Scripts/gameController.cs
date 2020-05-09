using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class gameController : MonoBehaviour
{
    bool avanza;
    private Animator carroAnim;
    public GameObject carro;
    public Text score;
    public Text finalScore; 
    public int puntaje;

    // Start is called before the first frame update
    void Start()
    {
        carroAnim = GetComponent<Animator>();
        avanza = false;
        carroAnim.SetBool("run", avanza);
        puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Puntaje: " + puntaje.ToString("f0");
        if (puntaje == 200)
        {
            finalScore.text = "¡Felicidades! ¡Puntuación perfecta! \n" + puntaje.ToString("f0");
        }
        else
        {
            finalScore.text = "Tu puntaje final es: \n" + puntaje.ToString("f0");
        }


        if (Input.GetKeyDown("space") && avanza==false)
        {
            iniciar();
            
            
        }
        //else if (Input.GetKeyDown("space") && avanza == true)
        //{
        //    parar();
        //}
    }

    void iniciar()
    {
        avanza = true;
        carroAnim.SetBool("run", avanza);
    }

    void parar()
    {
        avanza = false;
        carroAnim.SetBool("run", avanza);
    }

   void reinicio()
    {

    }
}
