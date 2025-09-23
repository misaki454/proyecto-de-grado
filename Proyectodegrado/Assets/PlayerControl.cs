
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float velocidad = 5f;
    public Animator animator;

    void Update()
    {
        float velocidadX = Input.GetAxis("Horizontal");

        animator.SetFloat("movimiento", velocidadX);

        if (velocidadX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (velocidadX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1); 
        }

        Vector3 posicion = transform.position;

        transform.position = new Vector3(posicion.x + velocidadX * velocidad * Time.deltaTime, posicion.y, posicion.z);
    }
}