using UnityEngine;
using Assets.Code.Interfaces;
namespace Assets.Code.States
{
	public class StateMenu : InterfacesStados
	{
		private GameManager manager;
		private GameObject guiUserName;
		private float musicVolume;
		private float soundFXVolume;
		private Rect titleScreenPos;

		public StateMenu (GameManager managerRef)
		{
			manager = managerRef;

			if(Application.loadedLevelName != "Menu")
				Application.LoadLevel("Menu");
		}

		public void OnStateLevelLoad (int level)
		{
			if (level == 2)
			{
				this.musicVolume = manager.gameDataRef.musicVolume;
				this.soundFXVolume = manager.gameDataRef.soundFXVolume;
				guiUserName = GameObject.Find("GUI_pop_user");
				titleScreenPos = GameObject.Find("GUI_pop_title").guiText.GetScreenRect();

				if(guiUserName != null)
				{
					guiUserName.GetComponent<MostrarUsuario>().DisplayText(manager.gameDataRef.userName);
				}
			}
		}

		public void StateUpdate ()
		{
			if (Application.isLoadingLevel != true) 
			{
				manager.gameDataRef.musicVolume = this.musicVolume;
				manager.gameDataRef.soundFXVolume = this.soundFXVolume;
			}
		}

		public void ShowIt ()
		{
			if(GUI.Button(new Rect(titleScreenPos.xMax, Screen.height * 0.1f, 20, 20), new GUIContent("X", "Click para salir")))
			{
				manager.SwitchState(new StateHome(manager));
			}

			musicVolume = GUI.HorizontalSlider(new Rect(Screen.width * 0.65f, Screen.height * 0.28f, Screen.width * 0.25f, 20), musicVolume, 0, 1);
			soundFXVolume = GUI.HorizontalSlider(new Rect(Screen.width * 0.65f, Screen.height * 0.20f, Screen.width * 0.25f, 20), soundFXVolume, 0, 1);

			if(GUI.Button(new Rect(Screen.width*0.2f, Screen.height * 0.5f, Screen.width - Screen.width*0.4f, 20), "Reglas de Juego"))
			{}

			if(GUI.Button(new Rect(Screen.width*0.2f, Screen.height * 0.5f + 30, Screen.width - Screen.width*0.4f, 20), "Creditos"))
			{}

			if(GUI.Button(new Rect(Screen.width*0.2f, Screen.height * 0.5f + 60, Screen.width - Screen.width*0.4f, 20), "Terminos y Condiciones"))
			{}

			if(GUI.Button(new Rect(Screen.width*0.2f, Screen.height * 0.5f + 90, Screen.width - Screen.width*0.4f, 20), "Politicas de Privacidad"))
			{}

			if(GUI.Button(new Rect(Screen.width*0.2f, Screen.height * 0.5f + 120, Screen.width - Screen.width*0.4f, 20), "Soporte Tecnico"))
			{}
		}
	}
}

