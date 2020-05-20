using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class switchStop : MonoBehaviour
{
    public GameObject textoFinal;
    public GameObject globos;
    public GameObject texto;
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
        if(other.tag== "jugador")
        {
            textoFinal.SetActive(true);
            globos.SetActive(false);
            texto.SetActive(false);
        }
    }

    public void reinicio()
    {
        SceneManager.LoadScene(1);
    }

    public void salirDeAqui()
    {
        SceneManager.LoadScene(0);
    }
}
