using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarColor : MonoBehaviour
{
    MeshRenderer MeshRenderer;

    public Material[] materiales;
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
        InvokeRepeating("cambioColor",0f,1f);
    }
    public void cambioColor()
	{
        int color = Random.Range(0,materiales.Length-1);
        MeshRenderer.material = materiales[color];
	}
}
