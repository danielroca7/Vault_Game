using UnityEngine;
using System.Collections;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateRegister : InterfacesStados
	{
		private GameManager manager;
		public GameObject cubo;
		public string userName = "CORREO";
		public string password = "X X X X X X";
		private GUISkin mySkin;
		public Texture2D botonTex;

		public StateRegister (GameManager managerRef)
		{
			if(Application.loadedLevelName != "Login")
				Application.LoadLevel("Login");
			cubo = GameObject.Find ("Cube");
			cubo.GetComponent<Rotar> ().enabled = true;
			manager = managerRef;
			botonTex = (Texture2D) manager.gameDataRef.texturaBoton;
			mySkin = manager.gameDataRef.mySkin;
		}

		public void OnStateLevelLoad (int level)
		{

		}
		public void StateUpdate ()
		{
		}

		public void ShowIt ()
		{			
			GUI.skin = mySkin;

			GUI.skin.button.hover.textColor = Color.cyan;

			//Set the GUIStyle style to be label
			GUIStyle style = GUI.skin.GetStyle ("label");
			
			//Set the style font size to increase and decrease over time
			style.fontSize = (int)(20.0f + 10.0f * Mathf.Sin (Time.time));

			if(GUI.Button(new Rect(Screen.width/2 - 30, Screen.height * 0.75f - 40, 60, 20), 
			              new GUIContent("Entrar", "Rellena el <i>usuario</i> y <b>contrasenia</b> primero")))
			{
				manager.gameDataRef.userName = this.userName;
				manager.SwitchState(new StateHome(manager));
			}

			if(GUI.Button(new Rect(Screen.width/2 - 55, Screen.height * 0.75f - 10, 110, 20), "Nuevo Registro"))
			{
				manager.SwitchState(new StateNewRegister(manager));
			}

			GUI.Label(new Rect(Input.mousePosition.x + 20,Screen.height - Input.mousePosition.y - 20,
			                   150, 150), GUI.tooltip);

			userName = GUI.TextField(new Rect(Screen.width*0.1f, Screen.height*0.38f, Screen.width*0.75f, 20.0f), userName, 25);
			password = GUI.TextField(new Rect(Screen.width*0.1f, Screen.height*0.50f, Screen.width*0.75f, 20.0f), password, 25);
		}
	}
}

