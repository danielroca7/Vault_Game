using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateStore : InterfacesStados
	{
		private GameManager manager;
		private GUISkin mySkin;
		private int nivel;
		private int moduleActivo;
		private Rect positionButton;
		private Texture BarraEncabezadoAplicacion;
		private GameObject paquete1;
		private GameObject paquete2;
		private GameObject paquete3;
		private GameObject paquete4;
		private GameObject paquete5;
		private GameObject paquete6;
		private GameObject paquete7;
		private GameObject paquete8;
		private GameObject paquete9;
		private GameObject paquete10;
		private GameObject tituloEscena;
		private GameObject verPublicidad;
		private GameObject guiaVisualTextura;
		private string irEscena;


				
		public StateStore (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Store")
				Application.LoadLevel("Store");
			
			mySkin = manager.gameDataRef.mySkin;

		}
		
		public void StateUpdate ()
		{
			// Lineas de codigo que escala proporcional los objetos en la escena TIENDA
			// ------------------------------------------------------------------------------------------
			// Paquetes del 1 al 10
			//---------------------------------------------------------------------------------------------------------------------------------------
			paquete1.guiTexture.pixelInset = new Rect ((Screen.width * 0.3096F)*(-0.5F), (Screen.width * 0.3282F)*(-0.5F), Screen.width * 0.3096F, Screen.width * 0.3282F);
			paquete2.guiTexture.pixelInset = new Rect ((Screen.width * 0.3096F)*(-0.5F), (Screen.width * 0.3282F)*(-0.5F), Screen.width * 0.3096F, Screen.width * 0.3282F);
			paquete3.guiTexture.pixelInset = new Rect ((Screen.width * 0.3096F)*(-0.5F), (Screen.width * 0.3282F)*(-0.5F), Screen.width * 0.3096F, Screen.width * 0.3282F);
			paquete4.guiTexture.pixelInset = new Rect ((Screen.width * 0.3096F)*(-0.5F), (Screen.width * 0.3282F)*(-0.5F), Screen.width * 0.3096F, Screen.width * 0.3282F);
			paquete5.guiTexture.pixelInset = new Rect ((Screen.width * 0.3096F)*(-0.5F), (Screen.width * 0.3282F)*(-0.5F), Screen.width * 0.3096F, Screen.width * 0.3282F);
			paquete6.guiTexture.pixelInset = new Rect ((Screen.width * 0.3096F)*(-0.5F), (Screen.width * 0.3282F)*(-0.5F), Screen.width * 0.3096F, Screen.width * 0.3282F);
			paquete7.guiTexture.pixelInset = new Rect ((Screen.width * 0.3096F)*(-0.5F), (Screen.width * 0.3282F)*(-0.5F), Screen.width * 0.3096F, Screen.width * 0.3282F);
			paquete8.guiTexture.pixelInset = new Rect ((Screen.width * 0.3096F)*(-0.5F), (Screen.width * 0.3282F)*(-0.5F), Screen.width * 0.3096F, Screen.width * 0.3282F);
			paquete9.guiTexture.pixelInset = new Rect ((Screen.width * 0.3096F)*(-0.5F), (Screen.width * 0.3282F)*(-0.5F), Screen.width * 0.3096F, Screen.width * 0.3282F);
			paquete10.guiTexture.pixelInset = new Rect ((Screen.width * 0.4272F)*(-0.5F), (Screen.width * 0.3282F)*(-0.5F), Screen.width * 0.4272F, Screen.width * 0.3282F);
			//------------------------------------------------------------------------------------------------------------------------------
			//BotonVerPublicidad
			//-------------------------------------------------------------------------------------------------------------
			verPublicidad.transform.FindChild ("TexturaVerPublicidad").guiTexture.pixelInset =new Rect ((Screen.width * 0.195F)*(-0.5F), (Screen.width * 0.1858F)*(-0.5F), Screen.width * 0.195F, Screen.width * 0.1858F);
			guiaVisualTextura.guiTexture.pixelInset = new Rect ((Screen.height * (-0.7526F))/2, Screen.height * (-0.5F), Screen.height * 0.7526F, Screen.height);

			//Fuentes
			//------------------------------------------------------------------------------------------------------------------------
			tituloEscena.guiText.fontSize = (int)(24F/323F*Screen.width);
			verPublicidad.transform.FindChild ("TextoBoton").guiText.fontSize = (int)(15F/323F*Screen.width);
			//-----------------------------------------------------------------------------------------------------------------------------
			this.irEscena = CualquierBoton.irEscena ;
			if (CualquierBoton.escena == true) 
			{


				switch (irEscena)
				{
				case "perfil":
					manager.SwitchState(new StateProfile(manager));
					break;

				case "historial":
					manager.SwitchState(new StateHist(manager));
					break;

				case "tienda":
					manager.SwitchState(new StateStore(manager));
					break;

				case "cofiguracion":
					manager.SwitchState(new StateMenu(manager));
					break;

				case "play":
					manager.SwitchState(new StatePlay(manager));
					break;

				case "inicio":
					manager.SwitchState(new StateHome(manager));
					break;

				case "default":

					break;

				}

			}
				
		}
		
		public void ShowIt ()
		{
			GUI.skin = mySkin;

			if(GUI.Button(new Rect(positionButton.xMin + 10, Screen.height * (1 - positionButton.xMin / Screen.height) - 20,
			                       20, 20), new GUIContent("", "Click para salir"), "buttonClose"))
			{
				manager.SwitchState(new StateHome(manager));
			}


			GUI.DrawTexture(new Rect(0, 0 , Screen.width, 50), BarraEncabezadoAplicacion, ScaleMode.StretchToFill, true, 10.0F);

		}

		public void OnStateLevelLoad (int level)
		{
			CualquierBoton.escena = false;
			CualquierBoton.irEscena = "default";
			this.BarraEncabezadoAplicacion = manager.gameDataRef.BarraEncabezadoAplicacion;
			paquete1 = GameObject.Find ("Paquete_1");
			paquete2 = GameObject.Find ("Paquete_2");
			paquete3 = GameObject.Find ("Paquete_3");
			paquete4 = GameObject.Find ("Paquete_4");
			paquete5 = GameObject.Find ("Paquete_5");
			paquete6 = GameObject.Find ("Paquete_6");
			paquete7 = GameObject.Find ("Paquete_7");
			paquete8 = GameObject.Find ("Paquete_8");
			paquete9 = GameObject.Find ("Paquete_9");
			paquete10 = GameObject.Find ("Paquete_10");
			tituloEscena = GameObject.Find ("Titulo_Vista");
			verPublicidad = GameObject.Find ("BotonVerPublicidad");
			guiaVisualTextura = GameObject.Find("GuiaVisualTextura");


		}

	}
}

