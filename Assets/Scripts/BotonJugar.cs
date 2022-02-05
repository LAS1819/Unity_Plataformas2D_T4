// PMDM - T4 UNITY - PLATAFORMAS 2D - Lluís Aracil Sabater 2DAM 21/22
// COMPORTAMIENTO DEL BOTÓN JUGAR DEL MENÚ PRINCIPAL
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Control de escenas

public class BotonJugar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Método para lanzar el juego al pulsar el botón
    public void LanzarJuego() {
        SceneManager.LoadScene("Nivel 1");
    }
}
