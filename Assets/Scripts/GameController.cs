// PMDM - T4 UNITY - PLATAFORMAS 2D - Lluís Aracil Sabater 2DAM 21/22
// SCRIPT DEL CONTRLADOR DEL JUEGO
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Objetos
    private GameStatus gameStatus;

    // Miembros privados
    private int puntos; // Puntos del jugador
    private int vidas; // Vidas del jugador
    private int nivelActual; // Nivel actual de juego
    private int objetosRestantes; // Número de objetos restantes para completar el nivel

    // Llamado en el primer frame
    void Start()
    {
        // Obtenemos el objeto con el estado del juego
        gameStatus = FindObjectOfType<GameStatus>();
        // Obtenemos objetos restantes
        objetosRestantes = FindObjectsOfType<Objeto>().Length; // Objetos tipo Objeto

        // Inicialiazciones mediante gameStatus
        puntos = gameStatus.puntos;
        vidas = gameStatus.vidas;
        nivelActual = gameStatus.nivelActual;

        // Comprobamos los objetos que son estrellas
        // foreach (GameObject objetoRestante in objetosRestantes) {
        //     // DEBUG
        //     Debug.Log("Nombre de objeto restante: " + objetoRestante.name);
        //     // FIN DEBUG
        // }

        // DEBUG
        Debug.Log("Puntos iniciales: " + puntos);
        Debug.Log("Vidas iniciales: " + vidas);
        Debug.Log("Objetos restantes: " + objetosRestantes);
        // FIN DEBUG
    }

    // Llamado una en cada frame
    void Update()
    {
        
    }

    // Método público para añadir puntuación al recoger objeto
    public void AnotarItemRecogido() {
        // Sumamos 100 puntos
        puntos += 100;

        // Añadimos puntos en el gameStatus
        gameStatus.puntos = puntos;

        // TODO: Comprobar qué objeto se ha recogido para controlar sólo las estrellas
        // Restamos objeto
        objetosRestantes--;

        // DEBUG
        Debug.Log("Puntos: " + puntos);
        Debug.Log("Objetos restantes: " + objetosRestantes);
        // FIN DEBUG

        // Si objetos restantes llega a cero
        if (objetosRestantes <= 0) {
            // Llamamos función para cargar el siguiente nivel
            AvanzarNivel();
        }
    }

    // Método para restar una vida al jugador
    public void PerderVida() {
        vidas--; // Restamos una vida

        // Pasamos las vidas al gameStatus
        gameStatus.vidas = vidas;
        
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

    // Método para avanzar de nivel
    public void AvanzarNivel() {
        // Sumamos un nivel
        nivelActual++;
        // Si hemos llegado al nivel máximo, volvemos al inicio
        if (nivelActual > gameStatus.nivelMaximo) {
            nivelActual = 1;
        }
        // Damos información del nivel a gameStatus
        gameStatus.nivelActual = nivelActual;

        // Cargamos nivel que toca
        SceneManager.LoadScene("Nivel " + nivelActual);
    }
}
