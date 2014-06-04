using UnityEngine;
using Assets.Code.Interfaces;
using System.Collections;

public class GameData : MonoBehaviour {

	public Texture texturaFondo;
	public Texture texturaBoton;
	private string _userName;
	public float musicVolume;
	public float soundFXVolume;
	public string refAccount;
	public string phone;
	public string mail;
	public GUISkin mySkin;
	private AudioClip pista;

	public string userName
	{
		get
		{
			return this._userName;
		}

		set
		{
			this._userName = value;
		}
	}

	void Start ()
	{
		userName = "no user";
		musicVolume = 1;
		soundFXVolume = 1;
		refAccount = "xxx-xxxx-xxxx-xx";
		phone = "(xxx) xxx-xxxx";
		mail = "e.mail123@mail.com";
		pista = audio.clip;
	}

	void Update ()
	{
		audio.volume = musicVolume;	
	}
}
