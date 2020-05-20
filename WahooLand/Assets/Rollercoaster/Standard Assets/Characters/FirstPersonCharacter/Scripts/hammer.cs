using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour
{
    bool attack = false;
    private Animator armaAnim;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        armaAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Mouse0))
        if (Input.GetMouseButton(0))
        {
            attack = true;
            armaAnim.SetBool("atk", attack);
            this.tag = "golpe";

        }
        else
        {
            attack = false;
            armaAnim.SetBool("atk", attack);
            this.tag = "martillo";
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "salmon")
    //    {
    //        gameManager.GetComponent<juegoTopoScript>().puntaje += 10;
    //    }
    //}
}
