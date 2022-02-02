// PMDM - T4 UNITY - PLATAFORMAS 2D - Lluís Aracil Sabater 2DAM 21/22
// SCRIPT DEL CONTRLADOR DEL JUEGO
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Miembros privados
    private int puntos; // Puntos del juego

    // Llamado en el primer frame
    void Start()
    {
        // Inicializamos puntos
        puntos = 0;
    }

    // Llamado una en cada frame
    void Update()
    {
        
    }

    // Método público para añadir puntuación al recoger objeto
    public void AnotarItemRecogido() {
        // Sumamos 100 puntos
        puntos += 100;
        // DEBUG
        Debug.Log("Puntos: " + puntos);
        // FIN DEBUG
    }
}
