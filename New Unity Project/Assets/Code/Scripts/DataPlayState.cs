using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DataPlayState : MonoBehaviour {

	public List<GameObject> modulePrefabs;
	public int numeroAdivinar;

	void Start () 
	{
		switch(GameObject.Find("GameManager").GetComponent<GameData>().nivel)
		{
		case 1:
			numeroAdivinar = Random.Range(0,10);
			break;

		case 2:
			numeroAdivinar = Random.Range(0,100);
			break;

		case 3:
			numeroAdivinar = Random.Range(0,1000);
			break;
		}

	}
}
