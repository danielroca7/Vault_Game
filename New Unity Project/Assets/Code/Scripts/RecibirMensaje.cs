using UnityEngine;
using System.Collections;

public class RecibirMensaje : MonoBehaviour {

	public GUIText textModule;

	void Start ()
	{
		textModule = GetComponentInChildren<GUIText>();
	}
	public void EscribirEnModulo (string mensaje)
	{
		textModule.text = mensaje;
	}
}
