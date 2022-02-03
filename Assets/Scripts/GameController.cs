// PMDM - T4 UNITY - PLATAFORMAS 2D - Lluís Aracil Sabater 2DAM 21/22
// SCRIPT DEL CONTRLADOR DEL JUEGO
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Miembros privados
    private int puntos; // Puntos del jugador
    private int vidas; // Vidas del jugador

    // Llamado en el primer frame
    void Start()
    {
        // Inicialiazciones
        puntos = 0;
        vidas = 3;
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

    // Método para restar una vida al jugador
    public void PerderVida() {
        vidas--; // Restamos una vida
        // Obtenemos el objeto del jugador y madamos el mensaje Recolocar
        FindObjectOfType<Jugador>().SendMessage("Recolocar");

        // DEBUG
        Debug.Log("Quedan " + vidas + " vidas.");

        // Si tiene vidas
        if (vidas <= 0) {
            // DEBUG
            Debug.Log("Partida terminada");
            // FIN DEBUG
            // Terminamos juego
            Application.Quit();
        }
        // FIN DEBUG
    }
}
