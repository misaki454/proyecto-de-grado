using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PausarJuego : MonoBehaviour
{
    public GameObject MenuPausa;
    public bool juegoPausado = false;


        private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pausar();
            }
        }
    }
    public void Reanudar()
    {
        MenuPausa.SetActive(false);
        Time.timeScale = 1;
        juegoPausado = false;
    }
    public void Pausar()
    {
        MenuPausa.SetActive(true);
        Time.timeScale = 0;
        juegoPausado = true;
    }
    public void irAlMenu()
    {
       
        SceneManager.LoadScene("MenuInicial");
    }
    public void irAlSelector()
    {
        Reanudar();
        SceneManager.LoadScene("SeleccionHistorias");
    }
}


 

