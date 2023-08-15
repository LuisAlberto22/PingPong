using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    public GameObject canvas;

    public int maxPuntos = 100;

    public movimiento jugador1;

    public movimiento2 jugador2;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    public bool gano(int puntos)
	{
		if (puntos >= maxPuntos)
		{
            return true;
		}
        return false;
	}

    public void resetearPosicion()
	{
        jugador1.resetear();
        jugador2.resetear();
        Instantiate(canvas);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
