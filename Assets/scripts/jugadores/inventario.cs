using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventario : MonoBehaviour
{
	public Image[] poderesImage;

    public List<poderes> poderes;

	public GameObject jugador2;

	public poderes estado { get; set; }

	void Start()
    {
        poderes = new List<poderes>(2);
    }

	public bool Estado(poderes poderes)
	{
		if (estado != null)
		{
			estado = poderes;
			return true;
		}
		return false;
	}

    public void activarPoder()
	{
		if (poderes.Count>0)
		{
			poderes[poderes.Count - 1].power(gameObject,jugador2);
			poderesImage[poderes.Count - 1].enabled = false;
			poderes.RemoveAt(poderes.Count - 1);
		}
	}

    public bool agregarPoder(poderes poder, Sprite image)
	{
		if (poderes.Count < 2)
		{
            poderes.Add(poder);
			poderesImage[poderes.Count - 1].sprite = image;
			poderesImage[poderes.Count - 1].enabled = true;
			return true;
		}
		return false;
	}
}
