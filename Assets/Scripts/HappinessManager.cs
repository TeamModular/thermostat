using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class HappinessManager : MonoBehaviour 
{

	public double happinessValue;
	public double happyDistance;
	public List<Light> lights;
	public Slider happinessSlider;

	// Use this for initialization
	void Awake () 
	{

	}
	void Start()
	{}

	void handleHappiness()
	{
		if (happinessValue>0 && !lightInRange())
			happinessValue -= 1 * Time.deltaTime;
	}

	bool lightInRange()
	{
		foreach (Light light in lights) 
		{
			if (light.enabled) 
			{
				if (Vector3.Distance (transform.position, light.transform.position) < happyDistance ) 
				{
					return true;
				}
			}
		}
		return false;
	}

	// Update is called once per frame
	void Update () 
	{
		handleHappiness ();
		happinessSlider.value = (float)happinessValue / 100;
	
	}
}
