using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
	public static int count = 0;
	private Text myText;

	//Initializes the score
	private void Start()
	{
		myText = GetComponent<Text>();
		myText.text = "Nonthing yet";
		Reset();
	}

	//add to score function
	public void Score(int points)
	{
		count += points;
		myText.text = "Counter: " + count.ToString();
	}

	//sets score to 0
	public static void Reset()
	{
		count = 0;
	}
}