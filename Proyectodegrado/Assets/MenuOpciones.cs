using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    public void CambiarVolumen(float volumen)
{
    if (volumen <= 0.0001f)
    {
        audioMixer.SetFloat("volumen", -80f); // Silencio total
    }
    else
    {
        float volumenDB = Mathf.Log10(volumen) * 20;
        audioMixer.SetFloat("volumen", volumenDB);
    }
}
    public void CambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
   }
        
    
}
