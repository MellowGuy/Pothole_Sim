using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotholeSpawner : MonoBehaviour
{

	public float width = 5f;
	public float height = 5f;

	public GameObject potholePrefab;
	public float potholeSpeed = 5f;
	public float potsPerSecond = 1f;


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			print("Pothole Spawn button");
			CreatePothole();
		}
		float probability = Time.deltaTime * potsPerSecond;
		if (UnityEngine.Random.value < probability)
		{
			CreatePothole();
		}
	}

	private void CreatePothole()
	{
		//gets a random value between either end of the width property
		float potholeRandomPos = UnityEngine.Random.Range(-width / 2, width / 2);
		//creates spawn postion based on random value
		Vector3 potholeSpawnPosition = new Vector3(potholeRandomPos, transform.position.y, transform.position.z);
		//creates the pothole instance and gives it a velocity downwards
		GameObject potholeInstance = Instantiate(potholePrefab, potholeSpawnPosition, Quaternion.identity);
		potholeInstance.GetComponent<Rigidbody2D>().velocity = Vector3.down * potholeSpeed;

	}

	//Puts wire cube on spawner
	public void OnDrawGizmos()
	{
		Gizmos.DrawWireCube(transform.position, new Vector3(width, height));
	}
}
