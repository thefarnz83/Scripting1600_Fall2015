using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour 
{
	//create your new number that you would like to start with.
	int score = 100;

	// Use this for initialization
	void Start () 
	{
		//int score = the function you are using below (what you want the function to affect).
		score = subtracthealth (score);
		Debug.Log (score);
	}
	//create the function box by creating a new int using what it does as the name.
	int subtracthealth (int damage)
	{
		//create new int to return.
		int ret;
		//name the new ret int using what it does.
		ret =  damage - 50;
		//return the ret var.
		return ret;
	}
	//Below not used.
	// Update is called once per frame
	void Update () 
	{
	
	}
}
