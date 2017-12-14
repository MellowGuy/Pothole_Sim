using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
	public float maxDistanceDelta = 1f;


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		MoveCar();
		Debug.Log("Car Position: " + transform.position);

	}

	private void MoveCar()
	{

		transform.position = Vector3.MoveTowards(transform.position, Input.mousePosition, maxDistanceDelta * Time.deltaTime);
	}
}
