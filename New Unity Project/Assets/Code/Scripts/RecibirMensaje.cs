using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecibirMensaje : MonoBehaviour {

	public GUIText[] textModule;
	private int moduleActivo;
    
	void Start ()
	{
		textModule = GetComponentsInChildren<GUIText>();
		moduleActivo = 0;
	}

	public void EscribirEnModulo (string mensaje)
	{
		textModule[moduleActivo].text = mensaje;
		StopCoroutine("Reiniciar");
		
		if(Comparar ())
		{
			StartCoroutine ("Reiniciar", true);
		} else
		{
			StartCoroutine("Reiniciar", false);
		}


	}
	
	private IEnumerator Reiniciar (bool acierto)
	{
		if(acierto == true)
		{
			GUI.Box(new Rect(Screen.width - 25, Screen.height - 10, 50, 20), "Acertaste");
			yield return new WaitForSeconds (2.0F);
		} else
		{
			GUI.Box(new Rect(Screen.width - 25, Screen.height - 10, 50, 20), "Intentalo de nuevo");
			yield return new WaitForSeconds (2.0F);
			//Se pone el "-" en caso de que se haya equivocado
			EscribirEnModulo("-");
		}
	}
	
	private bool Comparar()
	{
		return (textModule[moduleActivo].text == "5"); 
	}
}
