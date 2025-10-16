

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public PlayerSoundController playerSoundController;
    public float velocidad = 5f;
    public bool step1 = false;
    public bool fall = false;
    public float timeByStep = 0.2f;
    float cont = 0f;

    public float longitudRaycast = 0.1f;
    public LayerMask capasuelo;
    private bool ensuelo;
    float scaleZ;
    public Animator animator;

    void Start()
    {
        scaleZ = transform.localScale.z;
    }

    void Update()
    {
        Movimiento();

        // Detectar si está en el suelo con Raycast
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, longitudRaycast, capasuelo);
        ensuelo = hit.collider != null;

        // Sonido al caer
        if (ensuelo && fall)
        {
            playerSoundController.playCaida();
            fall = false;
        }

        // Actualizar parámetro del Animator
        animator.SetBool("ensuelo", ensuelo);
    }

    public void Movimiento()
    {
        float direccion = Input.GetAxis("Horizontal");
        animator.SetFloat("movimiento", Mathf.Abs(direccion));

        // Movimiento físico del personaje
        Vector3 posicion = transform.position;
        transform.position = new Vector3(posicion.x + direccion * velocidad * Time.deltaTime, posicion.y, posicion.z);

        // Sonidos de pasos cuando está en el suelo y se mueve
        if (direccion != 0 && ensuelo)
        {
            cont += Time.deltaTime;
            if (cont >= timeByStep)
            {
                cont = 0f;
                if (step1)
                    playerSoundController.playMov1();
                else
                    playerSoundController.playMov2();

                step1 = !step1;
            }
        }

        // Cambiar dirección visual
        if (direccion < 0)
            transform.localScale = new Vector3(-1, 1, 1);
        else if (direccion > 0)
            transform.localScale = new Vector3(1, 1, 1);

        // Si está cayendo
        if (!ensuelo && GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            fall = true;
        }
    }
}
