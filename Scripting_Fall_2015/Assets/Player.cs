using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float moveSpeed = 5f;
	public float turnSpeed = 25f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate (Vector3.up * -turnSpeed * Time.deltaTime);
	}
}
