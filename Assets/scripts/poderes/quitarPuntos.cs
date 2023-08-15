using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitarPuntos : poderes
{
	
	public override bool asignar(inventario jugador)
	{
		return jugador.agregarPoder(this, imagen);
	}

	public override void power(GameObject jugador, GameObject jugador2)
	{
		jugador2.GetComponent<contador>().aumentarPuntuacion(-15);
		Destroy(gameObject);
	}
}
