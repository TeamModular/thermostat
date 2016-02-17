using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour 
{
	Light source;
	AudioSource lightToggle;
	// Use this for initialization
	void Start () 
	{
		source  = GetComponentInChildren<Light>();
		lightToggle = GetComponentInChildren<AudioSource> ();
	}

	public void OnMouseDown()
	{
		Toggle ();
		lightToggle.Play ();
	}

	private void Toggle() 
	{
		source.enabled = !source.enabled;
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
