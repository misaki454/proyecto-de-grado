using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SonidoCambioScene : MonoBehaviour

{
    private static SonidoCambioScene instancia;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject); // Evita que se destruya al cambiar de escena
        }
        else
        {
            Destroy(gameObject); // Evita duplicados
        }
    }
    void Update()
    {
    
        string SeleccionHistoria = SceneManager.GetActiveScene().name;

        if (SeleccionHistoria == "Historia_1") 
        {
            Destroy(gameObject);
        }
    }

}
