using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
	public Controller controller;
	public contador jugador;
	ParticleSystem particleSystem;
	AudioSource audio;
	private void Start()
	{
		audio=GameObject.Find("silbato").GetComponent<AudioSource>();

		particleSystem = GetComponentInChildren<ParticleSystem>();
	}
	// Start is called before the first frame update
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "pelota")
		{
			audio.Play();
			particleSystem.transform.position = new Vector3(particleSystem.transform.position.x, particleSystem.transform.position.y,collision.transform.localPosition.z);
			particleSystem.Play();
			jugador.aumentarPuntuacion(15);
			controller.resetearPosicion();
			Destroy(collision.gameObject);
		}
	}
}
