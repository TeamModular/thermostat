using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class HappinessManager : MonoBehaviour 
{

	public double happinessValue;
	public List<GameObject> rooms;
	public Image happyGlyph;
	public Slider happinessSlider;
    public double happinessStep = 30;
	bool sadnessCooldown = false;
	float timeOfLastHappiness = 0;
	bool movingRooms=false;
	// Use this for initialization

	public bool getSadness()
	{
		return sadnessCooldown;
	}

	void Awake () 
	{

	}
	void Start()
	{}

	IEnumerator initiateSadnessCooldown(float time)
	{
		sadnessCooldown = true;
		yield return new WaitForSeconds (time);

		sadnessCooldown = false;
	}
		

	void handleHappiness()
	{
		if (!lightInRange ()) 
		{
			float currentTime = Time.time;
			if (timeOfLastHappiness < currentTime && !movingRooms) {//initiate countdown
				timeOfLastHappiness = currentTime + (float)0.5;
				movingRooms = true;
			} else if (happinessValue > 0 && !sadnessCooldown && currentTime>=timeOfLastHappiness && movingRooms) {
				happinessValue -= happinessStep;
				happyGlyph.enabled = false;
				StartCoroutine (initiateSadnessCooldown (2));
			}
			
		} else 
		{
			movingRooms = false;
			timeOfLastHappiness = 0; //reset countdown
		}
		if (happinessValue < 100 && !sadnessCooldown) {
			happinessValue += Time.deltaTime;
			happyGlyph.enabled = true;
		} else {
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
