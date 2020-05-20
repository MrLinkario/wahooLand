using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salmonsitoScript : MonoBehaviour
{
    public float velocidadMovimiento;
    public float limteSup;
    public float limiteInf;
    public GameObject gameManager;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + velocidadMovimiento, this.transform.position.z); 


        if(this.transform.position.y >= limteSup)
        {
            velocidadMovimiento = -velocidadMovimiento;
        }

        if(this.transform.position.y <= limiteInf)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "golpe")
        {
            gameManager.GetComponent<juegoTopoScript>().puntaje += 1;
            Destroy(this.gameObject);
        }
    }
}
