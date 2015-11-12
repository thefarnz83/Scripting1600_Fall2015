using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour 
{
	public GameObject[] agents;
	// Use this for initialization
	void Start () 
	{
	agents = GameObject.FindGameObjectsWithTag("Agent");
		
		for(int i = 0; i < agents.Length; i++)
		{
			Debug.Log("Agent Number " +i+ " is named "+agents[i].name);
		}
	}
}