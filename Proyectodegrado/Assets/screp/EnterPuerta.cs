using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterPuerta : MonoBehaviour
{
    private bool enterAllowed;
    private string sceneToLoad;
   private void OnTriggerEnter2D(Collider2D collision) {
    if (collision.GetComponent<PuertaCafe>()){
        sceneToLoad ="galileoCasa";
        enterAllowed 0 true;
    }
    else if (collision .GetComponent<PuertaCafe2>()){
        sceneToLoad = "Histori_1";
        enterAllowed = true;
    }
        
    }
    
}
 private void OnTriggerExit2D(Collider2D collision) {
    if (collision.GetComponent<PuertaCafe>() || collision.GetComponent<PuertaCafe2>())
    {
        enterAllowed = false;

    }
    }
     private void Update() {
        if (enterAllowed && input.GetKey(KeyCode.Return)){
            SceneManagement.LoadScene(sceneToLoad);
        }
    }
    

