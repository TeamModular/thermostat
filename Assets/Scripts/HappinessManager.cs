using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class HappinessManager : MonoBehaviour 
{

	public double happinessValue;
	public double happyDistance;
	public List<GameObject> rooms;
	public Image happyGlyph;
	public Slider happinessSlider;

	// Use this for initialization
	void Awake () 
	{

	}
	void Start()
	{}

	void handleHappiness()
	{
		if (happinessValue > 0 && !lightInRange ()) 
		{
			happinessValue -= 1 * Time.deltaTime;
			happyGlyph.enabled = true;

		} else 
		{
			happyGlyph.enabled = false;
		}
	}

	bool lightInRange()
	{
		foreach (GameObject room in rooms) 
		{
			Light light = room.GetComponentInChildren<Light> ();
			BoxCollider collider = room.GetComponent<BoxCollider> ();
			if (light.enabled) 
			{
				if (collider.bounds.Contains(transform.position))
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
