using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DataPlayState : MonoBehaviour {

	public List<GameObject> modulePrefabs;
	public int numeroAdivinar;

	void Start () 
	{
		numeroAdivinar = Random.Range(0,1000);
	}
}
