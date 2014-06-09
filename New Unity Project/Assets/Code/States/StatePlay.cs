//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18408
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------
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
		private List<GameObject> modules;
		private List<GameObject> modulePrefabs;
		private DataPlayState dataPlayState;

		public StatePlay (GameManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Play")
				Application.LoadLevel("Play");
			
			mySkin = manager.gameDataRef.mySkin;

			modules = new List<GameObject> ();

			nivel = manager.gameDataRef.nivel;
			moduleActivo = 0;
		}

		public void StateUpdate ()
		{
			if(Application.isLoadingLevel == false && modules[0].GetComponent<RecibirMensaje>().textModule.text == "")
			{
				if(Comparar())
				{
					Debug.Log("Le acerto");
				}
			}
		}

		public void ShowIt ()
		{
			GUI.skin = mySkin;

		}

		public void OnStateLevelLoad (int level)
		{
			dataPlayState = GameObject.Find ("DataPlayState").GetComponent<DataPlayState> ();

			this.modulePrefabs = dataPlayState.modulePrefabs;

			modules.Add(Object.Instantiate (modulePrefabs [CualEs()], modulePrefabs [CualEs()].transform.position, modulePrefabs [CualEs()].transform.rotation) as GameObject);
		}

		private int CualEs ()
		{
			return 0;
		}

		private bool Comparar()
		{
			return modules [0].guiText.text == "5"; 
		}
	}
}

