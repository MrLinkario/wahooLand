using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController2 : MonoBehaviour
{
    private float speedBullet = 30.0f;
    private float tiempoVida = 0.0f;
 
    void Update()
    {
        this.transform.Translate(0.0f, 0.0f, speedBullet * Time.deltaTime);
        tiempoVida += Time.deltaTime;

        if (tiempoVida >= 2)
        {
            Destroy(this.gameObject);
        }
        //if (this.transform.position.x >= 25.0f || this.transform.position.x <= -25.0f)
        //{
        //    Destroy(this.gameObject);
        //}

        //if (this.transform.position.z >= 25.0f || this.transform.position.z <= -25.0f)
        //{
        //    Destroy(this.gameObject);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
       
            
            Destroy(this.gameObject);
        
    }
}