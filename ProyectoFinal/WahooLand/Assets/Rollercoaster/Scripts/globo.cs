using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globo : MonoBehaviour
{
    public GameObject controlador;
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
        if (other.tag == "bullet")
        {
            controlador.GetComponent<gameController>().puntaje += 5;
            Destroy(this.gameObject);
        }
    }
}
