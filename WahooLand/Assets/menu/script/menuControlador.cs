using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuControlador : MonoBehaviour
{
    public GameObject menuPrincipal;
    public GameObject montanaIns;
    public GameObject mansionIns;
    public GameObject salmonIns;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void regresarMenuPrinc()
    {
        menuPrincipal.SetActive(true);
        montanaIns.SetActive(false);
        mansionIns.SetActive(false);
        salmonIns.SetActive(false);
    }

    public void instruccionesMontana()
    {
        menuPrincipal.SetActive(false);
        montanaIns.SetActive(true);
    }

    public void instruccionesMansion()
    {
        menuPrincipal.SetActive(false);
        mansionIns.SetActive(true);
    }

    public void instruccionesSalmon()
    {
        menuPrincipal.SetActive(false);
        salmonIns.SetActive(true);
    }

    public void empezarMontana()
    {
        SceneManager.LoadScene(1);
    }

    public void empezarMansion()
    {
        SceneManager.LoadScene(2);
    }

    public void empezarSalmon()
    {
        SceneManager.LoadScene(3);
    }

    public void salirDelJuego()
    {
        Application.Quit();
    }
}
