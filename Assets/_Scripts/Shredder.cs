using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
	//Trigger enter objects get destroyed
	void OnTriggerEnter2D(Collider2D collision)
	{
		Destroy(collision.gameObject);
	}
}
