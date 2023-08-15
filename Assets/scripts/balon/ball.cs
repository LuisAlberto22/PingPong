using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
	public inventario jugador;

	public Transform respawn;

	private MeshRenderer Material;

	AudioSource audio;
	public int CordenadaX { get; set; }
	public int CordenadaZ { get; set; }

	public int Velocidad;

	Rigidbody Rigidbody;

	ParticleSystem particleSystem;
	// Start is called before the first frame update
	void Start()
	{
		respawn = transform;
		jugador = GameObject.Find("jugador1").GetComponent<inventario>();
		GameObject.Find("silbato").GetComponent<AudioSource>().Play();
		audio = GetComponent<AudioSource>();
		particleSystem = GetComponentInChildren<ParticleSystem>();
		Material = GetComponent<MeshRenderer>();
		Rigidbody = GetComponent<Rigidbody>();
		CordenadaX = Random.Range(0, 2);
		if (CordenadaX == 0)
		{
			CordenadaX = -1;
		}
		CordenadaZ = Random.Range(0, 2);
		if (CordenadaZ == 0)
		{
			CordenadaZ = -1;
		}
		Rigidbody.velocity = new Vector3(CordenadaX * Velocidad, 0, CordenadaZ * Velocidad);
	}
	public void resetearPosicion()
	{
		transform.localPosition = respawn.localPosition;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "poder")
		{
			if (other.GetComponent<poderes>().asignar(jugador))
			{
				other.transform.Translate(new Vector3(0, -10));
			}
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		audio.Play();
		particleSystem.startColor = collision.gameObject.GetComponent<MeshRenderer>().material.color;
		Material.material = collision.gameObject.GetComponent<MeshRenderer>().material;
		if (collision.gameObject.tag == "Player")
		{
			jugador = collision.gameObject.GetComponent<inventario>();
		}
	}

}
