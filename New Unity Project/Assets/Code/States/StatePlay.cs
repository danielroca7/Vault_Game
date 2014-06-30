using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class StatePlay : InterfacesStados
	{
		private GameManager manager;
		private GUISkin mySkin;
		private int nivel;
		private int moduleActivo;
		private GameObject module;
		private List<GameObject> modulePrefabs;
		private DataPlayState dataPlayState;
		private GameObject tecladoPlay;
		private GUITexture digito0;
		private GUITexture digito1;
		private GUITexture digito2;
		private GUITexture digito3;
		private GUITexture digito4;
		private GUITexture digito5;
		private GUITexture digito6;
		private GUITexture digito7;
		private GUITexture digito8;
		private GUITexture digito9;


		
		public StatePlay (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Play")
				Application.LoadLevel("Play");
			
			mySkin = manager.gameDataRef.mySkin;
			
			nivel = manager.gameDataRef.nivel;
			moduleActivo = 0;
		}
		
		public void StateUpdate ()
		{
			//digito0.pixelInset.width = 10F;



		}
		
		public void ShowIt ()
		{
			GUI.skin = mySkin;

			// Boton Que pasa a la vista de historial
			if(GUI.Button(new Rect(Screen.width * 0.6f, Screen.height * 0.9f,70, 20), "Historial"))
			{
				manager.SwitchState(new StateHist(manager));
			}
		}
		
		public void OnStateLevelLoad (int level)
		{
			dataPlayState = GameObject.Find ("DataPlayState").GetComponent<DataPlayState> ();
			tecladoPlay = GameObject.Find ("GUI_pop_numberPad");
			digito0 = tecladoPlay.transform.Find ("GUI_pop_number0").GetComponent<GUITexture>();
			digito1 = tecladoPlay.transform.Find ("GUI_pop_number1").GetComponent<GUITexture>();
			digito2 = tecladoPlay.transform.Find ("GUI_pop_number2").GetComponent<GUITexture>();
			digito3 = tecladoPlay.transform.Find ("GUI_pop_number3").GetComponent<GUITexture>();
			digito4 = tecladoPlay.transform.Find ("GUI_pop_number4").GetComponent<GUITexture>();
			digito5 = tecladoPlay.transform.Find ("GUI_pop_number5").GetComponent<GUITexture>();
			digito6 = tecladoPlay.transform.Find ("GUI_pop_number6").GetComponent<GUITexture>();
			digito7 = tecladoPlay.transform.Find ("GUI_pop_number7").GetComponent<GUITexture>();
			digito8 = tecladoPlay.transform.Find ("GUI_pop_number8").GetComponent<GUITexture>();
			digito9 = tecladoPlay.transform.Find ("GUI_pop_number9").GetComponent<GUITexture>();




			this.modulePrefabs = dataPlayState.modulePrefabs;
			
			// Aqui instanciamos el GUI_module_1(Clone)
			module = Object.Instantiate (modulePrefabs [CualEs()], modulePrefabs [CualEs()].transform.position, modulePrefabs [CualEs()].transform.rotation) as GameObject;
			
			TecladoMensaje.modulo = module.GetComponent<RecibirMensaje>();
		}
		
		private int CualEs ()
		{
			return 2;
		}
	}
}

