using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour 
{
	public Image energyGlyph;
	public List<Light> lights;
	public double energy;
	public Slider energySlider;

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
		bool enableGlyph = false;
		foreach (Light light in lights) 
		{
			if (light.enabled && energy > 0) 
			{
				energy -= 1 * Time.deltaTime;
				if (!enableGlyph) 
				{
					enableGlyph = true;
				}
			} 
		}
		if (enableGlyph) 
		{
			energyGlyph.enabled = true;
		} else 
		{
			energyGlyph.enabled = false;
		}

	}

	// Update is called once per frame
	void Update () 
	{
		energySlider.value = (float)energy / 100;
		handleLights ();

	}
}
