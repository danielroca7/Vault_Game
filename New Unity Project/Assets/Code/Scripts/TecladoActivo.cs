/**
 * Esta Clase basicamente quiero que sirva para saver si el modulo esta activo para poder escribir sobre el.
 * En caso negativo, entonces, este modulo no hara algo.
 */
using UnityEngine;
using System.Collections;
public class TecladoActivo : MonoBehaviour
{

	public bool activo;

	void Start ()
	{
		activo = false;
	}
}

