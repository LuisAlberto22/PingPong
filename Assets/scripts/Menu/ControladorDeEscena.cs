using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDeEscena : MonoBehaviour
{
	public void CargarScena(int indice)
	{
		SceneManager.LoadScene(indice);
	}
}
