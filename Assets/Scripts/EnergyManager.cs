using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour 
{

	public List<Light> lights;
	public double energy;
	public Text energyText;

	void Awake()
	{
		energy = 100;
	}
	// Use this for initialization
	void Start () 
	{
		
	}

	void handleLights()
	{
		foreach (Light light in lights) 
		{
			if (light.enabled && energy>0) 
			{
				energy -= 1 * Time.deltaTime;
			}
		}
	}

	// Update is called once per frame
	void Update () 
	{
		energyText.text = "Energy: "+(int)energy;

		handleLights ();

	}
}
