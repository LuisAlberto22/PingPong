using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearPoderes : MonoBehaviour
{

	public GameObject[] poderes;

	public int maxPoderes;

	public int _numeroPoderes;

	void Start()
	{
		InvokeRepeating("crearPoder", 0f, 3.5f);
	}
	public int numeroPoderes
	{
		get
		{
			return _numeroPoderes;
		}
		set
		{
			_numeroPoderes = Mathf.Clamp(value,0,maxPoderes);
		}
	}

	void crearPoder()
	{
		if (numeroPoderes < maxPoderes)
		{
			float x = Random.Range(-4.29f,4.29f);
			float z = Random.Range(-4.49f, 4.49f);
			Instantiate(poderes[Random.Range(0,poderes.Length)],new Vector3(x,0.5f,z),Quaternion.identity);
			numeroPoderes++;
		}
	}
}
