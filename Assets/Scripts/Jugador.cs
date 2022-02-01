// PMDM - T4 UNITY - PLATAFORMAS 2D - Lluís Aracil Sabater 2DAM 21/22
// SCRIPT DEL COMPORTAMIENTO DEL JUGADOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Miembros públicos
    [SerializeField] float velocidadJugador = 5; // Velocidad del jugador
    [SerializeField] float velocidadSalto = 4; // Velocidad de salto

    // Miembros privados
    private Rigidbody2D rbJugador; // RigidBody2D del jugador
    private float posicionInicialX; // Posición X inicial del jugador
    private float posicionInicialY; // Posición Y inicial del jugador
    private float alturaJugador; // Altura del jugador

    // Método llamado en el primer frame del Update
    void Start()
    {
        // Obtenemos RigidBody2D del jugador
        rbJugador = GetComponent<Rigidbody2D>();

        // Obtenemos posiciones X e Y iniciales
        posicionInicialX = transform.position.x;
        posicionInicialY = transform.position.y;

        // Obtenemos la altura del jugador
        alturaJugador = GetComponent<Collider2D>().bounds.size.y;
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
        // // PRIMERA FORMA DE REALIZAR SALTO
        // // Recogemos el salto en una variable float
        // float salto = Input.GetAxis("Jump");
        // // Si salto es mayor a cero
        // if (salto > 0) {
        //     // DEBUG
        //     // Debug.Log("Entrando a Salto...");
        //     // FIN DEBUG

        //     // Después de realizar el salto comprobamos la distancia con el suelo con RaycastHit2D
        //     RaycastHit2D hit = Physics2D.Raycast(transform.position,
        //                                         new Vector2(0, -1));

        //     // Cuando el Raycast detecte suelo
        //     if (hit.collider != null) {
        //         // Guardamos distancia
        //         float distanciaAlSuelo = hit.distance;
        //         // Creamos buleano para comprobar si la distancia es menor a la altura del personaje
        //         bool tocandoElSuelo = distanciaAlSuelo < alturaJugador;
        //         // Cuando sea verdadero
        //         if (tocandoElSuelo) {
        //             // Indicamos fuerza de salto
        //             Vector3 fuerzaSalto = new Vector3(0, velocidadSalto, 0);
        //             // Generamos fuerza de salto
        //             rbJugador.AddForce(fuerzaSalto);
        //         }
        //     }

        //     // // Indicamos fuerza de salto
        //     // Vector3 fuerzaSalto = new Vector3(0, velocidadSalto, 0);
        //     // // Generamos fuerza de salto
        //     // rbJugador.AddForce(fuerzaSalto);
        // }

        // SEGUDA FORMA DE REALIZAR EL SALTO
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rbJugador.velocity.y) < 0.01f)
        {
            Vector3 fuerzaSalto = new Vector3(0, velocidadSalto, 0);
            rbJugador.AddForce(fuerzaSalto, ForceMode2D.Impulse);
        }
    }

    // Método para reposicionar jugador mediante posiciones iniciales
    void Recolocar() {
        // Ubicamos objeto del jugador en la posición inicial
        transform.position = new Vector3(posicionInicialX, posicionInicialY, 0);
    }
}
