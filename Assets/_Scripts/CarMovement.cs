using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
	public float maxDistanceDelta = 1f;
	public float steeringSpeed = 1f;
	public float xInputThrow;


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		MoveCar();
	}

	private void MoveCar()
	{

		/***************************NEED CAR MOVMENT TO BE BETTER.*********************************
		//probably uselsess
		xInputThrow = Input.GetAxis("Horizontal");
		Vector3 carXPositionTarget = new Vector3(xInputThrow, 0, 0) * steeringSpeed;
		transform.position = Vector3.MoveTowards(transform.position, carXPositionTarget, maxDistanceDelta * Time.deltaTime);
		*/

		//if-elseif statements to get either left or right arror keys to move position left or right. 
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * steeringSpeed * Time.deltaTime;
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * steeringSpeed * Time.deltaTime;
		}
	}
}
