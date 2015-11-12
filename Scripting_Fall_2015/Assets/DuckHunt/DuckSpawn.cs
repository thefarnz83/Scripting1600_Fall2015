using UnityEngine;
using System.Collections;

public class DuckSpawn : MonoBehaviour 
{
	public Rigidbody spherePrefab;
	public Transform spawnpoint;

	void OnTriggerEnter (Collider Hit)
	{
		if (Hit.transform.tag == "Dog") 
		{
			Rigidbody sphereInstance;
			sphereInstance = Instantiate (spherePrefab, spawnpoint.position, spawnpoint.rotation)as Rigidbody;
		}
	}

}