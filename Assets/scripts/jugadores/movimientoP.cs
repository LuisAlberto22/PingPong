using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoP : MonoBehaviour
{

    public int velJugador = 5;

    protected inventario inventario;
    protected Vector3 posicion;
    // Start is called before the first frame update
    public void aumentarVelocidad(int vel)
    {
        print(vel);
        velJugador = Mathf.Clamp(velJugador + vel, 3, 10);
    }

    public void resetear()
    {
        transform.localPosition = posicion;
    }
}
