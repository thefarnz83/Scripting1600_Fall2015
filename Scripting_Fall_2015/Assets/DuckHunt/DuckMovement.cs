using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour {
	Rigidbody rigidbody;
	public float speed;
	// Use this for initialization
	void Start () 
	{
		Rigidbody = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//limits the amount of force that is applied to the object so it doens't get out of control.
		if (rigidbody.velocity.x < speed && rigidbody.velocity.y < speed
	}
}
