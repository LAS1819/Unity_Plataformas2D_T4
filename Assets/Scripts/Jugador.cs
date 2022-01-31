using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Miembros públicos
    [SerializeField] float velocidadJugador = 5; // Velocidad del jugador
    [SerializeField] float velocidadSalto = 2; // Velocidad de salto

    // Miembros privados
    private Rigidbody2D rbJugador; // RigidBody2D del jugador

    // Método llamado en el primer frame del Update
    void Start()
    {
        // Obtenemos RigidBody2D del jugador
        rbJugador = GetComponent<Rigidbody2D>();
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
            // Indicamos fuerza de salto
            Vector3 fuerzaSalto = new Vector3(0, velocidadSalto, 0);
            // Generamos fuerza de salto
            rbJugador.AddForce(fuerzaSalto);
        }
    }
}
