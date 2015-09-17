using UnityEngine;
using System.Collections;

public class ifstatementstest : MonoBehaviour
{
	public float airspeed = 0f;
	public float increasespeed = 60f;

	void Update () 
	{
		//if (Input.GetKeyDown (KeyCode.Space))
			detectairspeed ();

		airspeed += Time.deltaTime * 10;
	}

	void detectairspeed ()
	{
		if (airspeed <= increasespeed) 
		{
			print ("Increase Speed!");
		}

		else
		{
			print ("Take Off!");
		}
	}
}
