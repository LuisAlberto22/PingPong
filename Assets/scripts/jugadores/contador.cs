using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contador : MonoBehaviour
{
	public Text cont;

	public Button Jugar;

	public Controller controller;
	public int puntos { get; set; }
	// Start is called before the first frame update
	void Start()
    {
        puntos = 0;
    }
	public void aumentarPuntuacion(int puntos)
	{
		this.puntos=Mathf.Clamp(this.puntos + puntos,0,115);
		cont.text = this.puntos.ToString();
		if (controller.gano(this.puntos))
		{
			Jugar.gameObject.SetActive(true);
			Time.timeScale = 0f;
			cont.text = "Ganaste";
		}
	}


}
