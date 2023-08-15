using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rapidez : poderes
{
	movimientoP movimiento;
	public override void power(GameObject jugador, GameObject jugador2)
	{
		movimiento = jugador.GetComponent<movimientoP>();
		tiempo = 3;
		movimiento.aumentarVelocidad(5);
		activo = true;
	}

	public override bool asignar(inventario jugador)
	{
		return jugador.agregarPoder(this,imagen);
	}

	private void Awake()
	{
		tiempo = 3;
	}
	void Update()
	{
		if (activo)
		{
			tiempo -= Time.deltaTime;
		}
		if (activo && tiempo < 0f)
		{
			movimiento.aumentarVelocidad(-5);
			Destroy(gameObject);
			activo = false;
		}
	}
}
