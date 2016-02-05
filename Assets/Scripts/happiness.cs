using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class happiness : MonoBehaviour 
{

	public double happinessValue;
	public Text happinessText;

	// Use this for initialization
	void Awake () 
	{
		happinessValue = 100;
	}

	void handleHappiness()
	{
		if (happinessValue>0)
			happinessValue -= 1 * Time.deltaTime;
	}

	// Update is called once per frame
	void Update () 
	{
		handleHappiness ();
		happinessText.text = "Happiness: " + (int)happinessValue;	
	
	}
}
