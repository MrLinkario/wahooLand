using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salirReinicio : MonoBehaviour
{
    public void salir()
    {
        Application.Quit();
    }

    public void reinicio()
    {
        SceneManager.LoadScene(0);
    }

    
}
