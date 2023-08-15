using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slow : poderes
{
	movimientoP movimiento;

	public override bool asignar(inventario jugador)
	{
		return jugador.agregarPoder(this, imagen);
	}

	public override void power(GameObject jugador, GameObject jugador2)
	{
		movimiento = jugador2.GetComponent<movimientoP>();
		tiempo = 3;
		movimiento.aumentarVelocidad(-2);
		movimiento.GetComponent<inventario>().estado = this;
		Invoke("desactivar", tiempo);
	}
	public void desactivar()
	{
		movimiento.aumentarVelocidad(2);
		Destroy(gameObject);
	}

	// Start is called before the first frame update
	private void Awake()
	{
		tiempo = 3;
	}
	
}
