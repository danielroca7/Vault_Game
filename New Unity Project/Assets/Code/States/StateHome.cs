using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StateHome : InterfacesStados
	{
		private GameManager manager;
		private GUISkin mySkin;
		private string irEscena;


		public StateHome (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Home")
				Application.LoadLevel("Home");

			mySkin = manager.gameDataRef.mySkin;
		}

		public void StateUpdate ()
		{
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

		}

		public void OnStateLevelLoad (int level)
		{

		}
	}
}

