using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiempo : MonoBehaviour
{
	movimiento jugador2;

	movimiento2 jugador1;

	public GameObject pelota;

	Transform respawn;

	Text text;

	public float t;

	// Start is called before the first frame update
	private void Awake()
	{
		jugador2 = GameObject.Find("jugador2").GetComponent<movimiento>();
		jugador1 = GameObject.Find("jugador1").GetComponent<movimiento2>();
		respawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Transform>();
		jugador1.enabled = false;
		jugador2.enabled = false;
		text = GetComponentInChildren<Text>();
		t = 3;
	}

	// Update is called once per frame
	void Update()
	{
		t -= Time.deltaTime;
		text.text = t.ToString("f0");
		if (t < 0.1f)
		{
			jugador1.enabled = true;
			jugador2.enabled = true;
			Instantiate(pelota, respawn);
			gameObject.GetComponent<Canvas>().enabled = false;
			Destroy(gameObject);
		}

	}
}
