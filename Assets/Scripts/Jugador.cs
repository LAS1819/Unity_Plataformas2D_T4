// PMDM - T4 UNITY - PLATAFORMAS 2D - Lluís Aracil Sabater 2DAM 21/22
// SCRIPT DEL COMPORTAMIENTO DEL JUGADOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Miembros públicos
    [SerializeField] float velocidadJugador = 5; // Velocidad del jugador
    [SerializeField] float velocidadSalto = 20; // Velocidad de salto

    // Miembros privados
    private Rigidbody2D rbJugador; // RigidBody2D del jugador
    private float posicionInicialX; // Posición X inicial del jugador
    private float posicionInicialY; // Posición Y inicial del jugador

    // Método llamado en el primer frame del Update
    void Start()
    {
        // Obtenemos RigidBody2D del jugador
        rbJugador = GetComponent<Rigidbody2D>();

        // Obtenemos posiciones X e Y iniciales
        posicionInicialX = transform.position.x;
        posicionInicialY = transform.position.y;
    }

    // Método Update llamado en cada frame
    void Update()
    {
        // ##############################
        // MOVIMIENTO
        // ##############################
        // Recogemos movimiento horizontal
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        // Generamos movimiento horizontal
        transform.Translate(movimientoHorizontal * velocidadJugador * Time.deltaTime, 0, 0);

        // SALTO
        // Recogemos el salto en una variable float
        float salto = Input.GetAxis("Jump");
        // Si salto es mayor a cero
        if (salto > 0) {
            // DEBUG
            // Debug.Log("Entrando a Salto...");
            // FIN DEBUG

            // Indicamos fuerza de salto
            Vector3 fuerzaSalto = new Vector3(0, velocidadSalto, 0);
            // Generamos fuerza de salto
            rbJugador.AddForce(fuerzaSalto);
        }
    }

    // Método para reposicionar jugador mediante posiciones iniciales
    void Recolocar() {
        // Ubicamos objeto del jugador en la posición inicial
        transform.position = new Vector3(posicionInicialX, posicionInicialY, 0);
    }
}
