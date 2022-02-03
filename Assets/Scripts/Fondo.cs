// PMDM - T4 UNITY - PLATAFORMAS 2D - Lluís Aracil Sabater 2DAM 21/22
// SCRIPT DE COMPORTAMIENTO DEL FONDO
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
    // Objetos
    GameController gameController;

    // Método llamado en el primer frame del Update
    void Start()
    {
        // Obtenemos el objeto GameController
        gameController = FindObjectOfType<GameController>();
    }

    // Método Update llamado en cada frame
    void Update()
    {
        
    }

    // Controlamos la colisión con el Collider2D
    private void OnTriggerEnter2D(Collider2D collision) {
        // DEBUG
        Debug.Log("Entrando a OnTriggerEnter2D...");
        // FIN DEBUG
        // Enviamos mensaje al objeto jugador para que lance la función Recolocar
        FindObjectOfType<Jugador>().SendMessage("Recolocar");

        // Enviamos mensaje al Controlador de Juego para perder una vida
        gameController.SendMessage("PerderVida");
    }
}
