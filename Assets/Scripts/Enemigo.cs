// PMDM - T4 UNITY - PLATAFORMAS 2D - Lluís Aracil Sabater 2DAM 21/22
// SCRIPT DE COMPORTAMIENTO DEL ENEMIGO
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // ATRIBUTOS ACCESIBLES DESDE EDITOR
    // ---------------------------------
    // Lista para Waypoints de enemigos accesible desde editor
    [SerializeField] List<Transform> wayPoints;
    // Atributo para la velocidad
    [SerializeField] float velocidadEnemigo;
    // ---------------------------------

    // ATRIBUTOS PRIVADOS
    // ---------------------------------
    private byte siguientePosicion; // Para saber la siguiente posición del WayPoint
    private float distanciaCambio;
    // ---------------------------------



    // Método llamado en el primer frame del Update
    void Start()
    {
        // INICIALIZACIONES
        siguientePosicion = 0; // Siguiente posición
        velocidadEnemigo = 0.4f; // Velocidad de enemigo
        distanciaCambio = 0.2f; // Distancia para cambiar al siguiente WP



        // DEBUG
        Debug.Log("Start " + wayPoints[siguientePosicion].transform.position);
        Debug.Log("Start-> " + gameObject.name + " tiene " + wayPoints.Count + " wayPoints");
        // FIN DEBUG
    }

    // Método Update llamado en cada frame
    void Update()
    {
        // DEBUG
        Debug.Log("Update " + wayPoints[siguientePosicion].transform.position);
        Debug.Log("Update-> " + gameObject.name + " tiene como siguientePosicion: " + siguientePosicion);
        // FIN DEBUG
        
        transform.position = Vector3.MoveTowards(transform.position,
            wayPoints[siguientePosicion].transform.position,
            velocidadEnemigo * Time.deltaTime);

        if (Vector3.Distance(transform.position,
            wayPoints[siguientePosicion].transform.position) < distanciaCambio) {
            siguientePosicion++;
            if (siguientePosicion >= wayPoints.Count) {
                siguientePosicion = 0;
            }   
        }
    }
}
