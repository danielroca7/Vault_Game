using System;
using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateHist : InterfacesStados
	{
		private GameManager manager;
		private GUISkin mySkin;

		// Texturas
		private Texture imagenReloj;
		private Texture termometro;


		// Variable que indica la posicion en Y de los iconos de tienda, datos, panel y temporizador.
		private float positionY;

		// Variable que indica el espacio entre botones.
		private float tamanoEstandasX;
		private float tamanoEstandasY;
		private float espacio;
		private float tamanoXPanel;
		private float tamanoXReloj;

		private Vector2 scrollPosition;
		private float vertScrollPosition;

		public StateHist (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Hist")
				Application.LoadLevel("Hist");

			this.mySkin = manager.gameDataRef.mySkin;
		}

		public void StateUpdate ()
		{
			tamanoEstandasX = Screen.height * 0.1199F; 
			tamanoEstandasY = Screen.height * 0.11F;
			tamanoXPanel = Screen.height * 0.0939F;
			tamanoXReloj = Screen.height * 0.2094F;
			positionY = Screen.height - tamanoEstandasY;
			espacio = (Screen.width - (tamanoXReloj + tamanoXPanel + (tamanoEstandasX * 2)))/5;

		}

		public void ShowIt ()
		{
			GUI.skin = mySkin;

			if(GUI.Button(new Rect(Screen.height * 0.01f, Screen.height * 0.03f, 20, 20), new GUIContent("", "Click para salir"), "buttonClose"))
			{
				manager.SwitchState(new StateHome(manager));
			}
			//----------------------------------------------------------------------------------------------------------------------------
			//Este boton me permite entrar a la pantalla de tienda
			//if(GUI.Button(new Rect(Screen.width - (tamanoEstandasX + (espacio*2)),positionY - espacio,tamanoEstandasX, tamanoEstandasY), "Tienda", "buttonStore"))
			//{
	
			//}
			//----------------------------------------------------------------------------------------------------------------------------
			//Este boton me permite entrar a la pantalla de cupones
			//if(GUI.Button(new Rect(Screen.width - espacio - (tamanoEstandasX * 2), positionY - espacio, tamanoEstandasX, tamanoEstandasY), "Cupones", "buttonCupones"))
			//{
			//	Debug.Log(tamanoEstandasX + "   "+tamanoEstandasY + "  espacio:"+ espacio);
			//}
			//----------------------------------------------------------------------------------------------------------------------------
			//Este boton me permite entrar a la pantalla de Panel
			//if(GUI.Button(new Rect(Screen.width - tamanoXPanel - (tamanoEstandasX * 2),positionY - espacio, tamanoXPanel, tamanoEstandasY), "Panel", "buttonPanel"))
			//{
			//	manager.SwitchState(new StatePlay(manager));
			//}
			//----------------------------------------------------------------------------------------------------------------------------
			scrollPosition = GUI.BeginScrollView (new Rect(Screen.width * 0.05F, Screen.height * 0.20F, Screen.width * 0.45F, Screen.height * 0.60F), 
			                                     scrollPosition, new Rect(0, 0, Screen.width * 0.4F, Screen.height * 3));

				GUI.DrawTexture (new Rect(0, 0, Screen.width * 0.4F, 100), termometro);

			GUI.EndScrollView ();
			//----------------------------------------------------------------------------------------------------------------------------
			//Textura de Reloj
			//GUI.DrawTexture (new Rect (espacio, positionY - espacio, tamanoXReloj, tamanoEstandasY -(espacio*3)), imagenReloj, ScaleMode.StretchToFill, true, 10.0F);

			//Textura de termometro
			//GUI.DrawTexture (new Rect (15, positionY, tamanoXPanel, tamanoEstandasY - espacio), termometro, ScaleMode.StretchToFill, true, 10.0F);
		}

		public void OnStateLevelLoad (int level)
		{
			this.imagenReloj = manager.gameDataRef.imagenReloj;
			this.termometro = manager.gameDataRef.termometro;
		}

	}
}

