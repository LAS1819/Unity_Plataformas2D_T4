// PMDM - T4 UNITY - PLATAFORMAS 2D - Lluís Aracil Sabater 2DAM 21/22
// SCRIPT DEL COMPORTAMIENTO DE PUNTUACIONES, VIDAS y DEMÁS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // Métodos públicos
    public int puntos = 0;
    public int vidas = 3;
    public int nivelActual = 1;
    public int nivelMaximo = 2;

    // Método AWAKE lanzado antes que el método START
    private void Awake() {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;

        // Si ya hay un gameStatus, lo destruimos
        if (gameStatusCount > 1) {
            Destroy(gameObject);
        }
        // Sino, no lo destruimos
        else {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
