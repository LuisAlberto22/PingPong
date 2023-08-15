using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : movimientoP
{
	private void Start()
	{
        inventario = GetComponent<inventario>();
        posicion = transform.localPosition;
	}
	void Update()
    {
		if (Input.GetKey(KeyCode.W) && transform.localPosition.z < 3.5f)
		{
            transform.Translate(new Vector3(0,0,velJugador)*Time.deltaTime);
		}
        if (Input.GetKey(KeyCode.S) && transform.localPosition.z > -3.5f)
        {
            transform.Translate(new Vector3(0, 0, -velJugador) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && transform.localPosition.x < -0.36)
        {
            transform.Translate(new Vector3(velJugador, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && transform.localPosition.x > -7.25f)
        {
            transform.Translate(new Vector3(-velJugador, 0, 0) * Time.deltaTime);
        }
		if (Input.GetKeyDown(KeyCode.E))
		{
            inventario.activarPoder();
		}
        ControlJugador1();
    }
    void ControlJugador1()
	{
		if (ControlVirtual1.inputVector1.z > 0)
		{
			if (transform.localPosition.z < 3.5f)
			{
                transform.Translate(new Vector3(0, 0, ControlVirtual1.inputVector1.z * velJugador) * Time.deltaTime);
			}
        }
        if (ControlVirtual1.inputVector1.z < 0)
        {
            if (transform.localPosition.z > -3.5f)
            {
                transform.Translate(new Vector3(0, 0, ControlVirtual1.inputVector1.z * velJugador) * Time.deltaTime);
            }
        }
        if (ControlVirtual1.inputVector1.x > 0)
        {
            if (transform.localPosition.x < -0.36f)
            {
                transform.Translate(new Vector3(ControlVirtual1.inputVector1.x * velJugador, 0,0 ) * Time.deltaTime);
            }
        }
        if (ControlVirtual1.inputVector1.x < 0)
        {
            if (transform.localPosition.x > -7.25f)
            {
                transform.Translate(new Vector3(ControlVirtual1.inputVector1.x * velJugador, 0, 0) * Time.deltaTime);
            }
        }
    }
}
