using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
	int count = 0;

	// Use this for initialization
	void Start()
	{
		Text countText = GetComponent<Text>();
		countText.text = "Count: " + count;
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void AddToCounter()
	{
		//adds 1 to counter.
	}
}
