using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento2 : movimientoP
{ 
	// Start is called before the first frame update
	// Update is called once per frame
	private void Start()
	{
		inventario = GetComponent<inventario>();

		posicion = transform.localPosition;
	}
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow) && transform.localPosition.z < 3.5f)
		{
			transform.Translate(new Vector3(0, 0, velJugador) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow) && transform.localPosition.z > -3.5f)
		{
			transform.Translate(new Vector3(0, 0, -velJugador) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.LeftArrow) && transform.localPosition.x > 0.36)
		{
			transform.Translate(new Vector3(-velJugador, 0, 0) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow) && transform.localPosition.x < 7.25f)
		{
			transform.Translate(new Vector3(velJugador, 0, 0) * Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			inventario.activarPoder();
		}
		ControlJugador2();
	}
	void ControlJugador2()
	{
		if (ControlVirtual2.inputVector2.z > 0)
		{
			if (transform.localPosition.z < 3.5f)
			{
				transform.Translate(new Vector3(0, 0, ControlVirtual2.inputVector2.z * velJugador) * Time.deltaTime);
			}
		}
		if (ControlVirtual2.inputVector2.z < 0)
		{
			if (transform.localPosition.z > -3.5f)
			{
				transform.Translate(new Vector3(0, 0, ControlVirtual2.inputVector2.z * velJugador) * Time.deltaTime);
			}
		}
		if (ControlVirtual2.inputVector2.x < 0)
		{
			if (transform.localPosition.x > 0.36)
			{
				transform.Translate(new Vector3(ControlVirtual2.inputVector2.x * velJugador, 0, 0) * Time.deltaTime);
			}
		}
		if (ControlVirtual2.inputVector2.x > 0)
		{
			if (transform.localPosition.x < 7.25f)
			{
				transform.Translate(new Vector3(ControlVirtual2.inputVector2.x * velJugador, 0, 0) * Time.deltaTime);
			}
		}
	}
}
