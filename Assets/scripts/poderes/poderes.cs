using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class poderes : MonoBehaviour
{
    public crearPoderes crearPoderes;

    public float tiempo;

    protected bool activo = false;

    public Sprite imagen;
    public abstract void power(GameObject jugador, GameObject jugador2);
    public abstract bool asignar(inventario jugador);
	private void Start()
	{
		crearPoderes = GameObject.FindGameObjectWithTag("generador").GetComponent<crearPoderes>();
	}
	private void OnDestroy()
	{
        crearPoderes.numeroPoderes = crearPoderes.numeroPoderes - 1;
	}

}
