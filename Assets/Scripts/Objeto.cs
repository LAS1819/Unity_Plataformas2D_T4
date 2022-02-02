// PMDM - T4 UNITY - PLATAFORMAS 2D - Lluís Aracil Sabater 2DAM 21/22
// SCRIPT DEL COMPORTAMIENTO DE LOS OBJETOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    // Instanciamos un controlador para el juego
    GameController gameController;

    // Llamado en el primer frame
    void Start()
    {
        // Obtenemos el objeto GameController
        gameController = FindObjectOfType<GameController>();
    }

    // Llamado una en cada frame
    void Update()
    {
        
    }

    // Método privado para detectar colisión
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            // Enviamos mensaje al objeto GameController
            gameController.SendMessage("AnotarItemRecogido");
            // Destruimos el objeto colisionado
            Destroy(gameObject);    
        }
        
    }
}
