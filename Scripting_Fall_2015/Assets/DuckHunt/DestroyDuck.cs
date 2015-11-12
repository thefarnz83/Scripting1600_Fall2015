using UnityEngine;
using System.Collections;

public class DestroyDuck : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, 3f);
	}



	void OnMouseDown () 
	{
		Destroy (gameObject);
	}


}
