using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoMenu : MonoBehaviour
{
    public GameObject usuario;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(usuario.transform.position.x, usuario.transform.position.y, usuario.transform.position.z);
    }
}
