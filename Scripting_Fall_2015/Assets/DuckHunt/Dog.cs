using UnityEngine;
using System.Collections;

public class Dog : MonoBehaviour 
{

	/*public float maxSpeed;

	public float xMax;
	public float zMax;
	public float xMin;
	public float zMin;

	private float x;
	private float z;
	private float time;
	private float angle;

	// Use this for initialization
	void Start () 
	{
	
	
		x = Random.Range(-maxSpeed, maxSpeed);
		z = Random.Range(-maxSpeed, maxSpeed);
	//angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
	transform.localRotation = Quaternion.Euler( 0, angle, 0);
	}

	// Update is called once per frame
	void Update () 
	{
	
		time += Time.deltaTime;
		
		if (transform.localPosition.x > xMax) {
			x = Random.Range(-maxSpeed, 0.0f);
			angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
			transform.localRotation = Quaternion.Euler(0, angulo, 0);
			tiempo = 0.0f; 
		}
		if (transform.localPosition.x < xMin) {
			x = Random.Range(0.0f, velocidadMax);
			angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
			transform.localRotation = Quaternion.Euler(0, angulo, 0); 
			tiempo = 0.0f; 
		}
		if (transform.localPosition.z > zMax) {
			z = Random.Range(-velocidadMax, 0.0f);
			angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
			transform.localRotation = Quaternion.Euler(0, angulo, 0); 
			tiempo = 0.0f; 
		}
		if (transform.localPosition.z < zMin) {
			z = Random.Range(0.0f, velocidadMax);
			angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
			transform.localRotation = Quaternion.Euler(0, angulo, 0);
			tiempo = 0.0f; 
		}
		
		
		if (tiempo > 1.0f) {
			x = Random.Range(-velocidadMax, velocidadMax);
			z = Random.Range(-velocidadMax, velocidadMax);
			angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
			transform.localRotation = Quaternion.Euler(0, angulo, 0);
			tiempo = 0.0f;
		}
		
		transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
	}*/
}