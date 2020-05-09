using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad, control, control2;

    // Start is called before the first frame update
    void Start()
    {
        //velocidad = 1;   
    }

    // Update is called once per frame
    void Update()
    {


        //movimiento automático
        //this.gameObject.transform.Translate(Vector3.forward * velocidad);


        //movimiento por control
        control = Input.GetAxis("Vertical");
        this.gameObject.transform.Translate(Vector3.forward * control*velocidad);
        control2 = Input.GetAxis("Horizontal");
        this.gameObject.transform.Translate(Vector3.right * control2 * velocidad);

    }
}
