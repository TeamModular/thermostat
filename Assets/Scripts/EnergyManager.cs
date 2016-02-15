using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour 
{
	public Button button;
	public Image energyGlyph;
	public List<Light> lights;
	public double energy;
	public Slider energySlider;
	public double energyReductionScaling;
	public float energyIncreaseAmount;
	public float energyCooldown;
	void Awake()
	{
		disableButton ();
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
				energy -= energyReductionScaling * Time.deltaTime;
				if (!enableGlyph) 
				{
					enableGlyph = true;
				}
			} 
			if (energy <= 0) 
			{
				light.enabled = false;
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

	public void increaseEnergy()
	{
		if (energy < 100 - energyIncreaseAmount)
			energy += energyIncreaseAmount;
		else
			energy = 100;
	}

	IEnumerator initiateEnergyCooldown(float time)
	{
		yield return new WaitForSeconds (time);

		button.image.enabled = true;
		button.enabled = true;
	}

	public void disableButton()
	{
		button.image.enabled = false;
		button.enabled = false;
		StartCoroutine (initiateEnergyCooldown (energyCooldown));
	}
}
