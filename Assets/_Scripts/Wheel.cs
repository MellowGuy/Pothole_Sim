using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
	Counter counter;
	public float wheelHealth = 10.0f;


	// Use this for initialization
	void Start()
	{
		counter = FindObjectOfType<Counter>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		print("Collider with: " + collision.name);
		counter.Score(1);
	}

	void OnDrawGizmos()
	{
		Gizmos.DrawCube(transform.position, transform.localScale);
	}
}
