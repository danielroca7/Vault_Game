using UnityEngine;
using System.Collections;

public class CualquierBoton : MonoBehaviour {



	public Texture dawnBoton;
	public Texture upBoton;
	public static bool escena = false;
	public static string irEscena = "default";


	/*void OnMouseUpAsButton () {
		this.guiTexture.texture = upBoton;
		Debug.Log("solte afuera");
	}*/

	void OnMouseDown ()
	{
		switch(gameObject.name)
		{
		case "Paquete_1":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name + this.guiTexture.texture);
			this.guiTexture.texture = dawnBoton;
			break;

		case "Paquete_2":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "Paquete_3":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "Paquete_4":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "Paquete_5":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;
		
		case "Paquete_6":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "Paquete_7":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "Paquete_8":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "Paquete_9":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "Paquete_10":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "BotonInicio":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			irEscena = "play";
			break;

		case "BotonVerPublicidad":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "BotonTienda":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			irEscena = "tienda";
			break;

		case "BotonRegalo":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "BotonPujas":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			irEscena = "puja";
			break;

		case "BotonPerfil":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			irEscena = "perfil";
			break;

		case "BotonLogros":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			irEscena = "logros";
			break;

		case "BotonFacebook":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			break;

		case "BotonEstadisticasDesempeño":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			irEscena = "estadisticas desempeño";
			break;

		case "BotonEstadisticasCupones":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			irEscena = "estadisticas cupones";
			break;

		case "BotonCupones":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			irEscena = "cupones";
			break;

		case "BotonConfiguracion":
			Debug.Log("estoy oprimiendo el boton " + gameObject.name );
			this.guiTexture.texture = dawnBoton;
			irEscena = "configuracion";
			break;

		}

	}

	void OnMouseUp () 
	{
		this.guiTexture.texture = upBoton;
		Debug.Log("solte adentro");
		escena = true;
	}
}
