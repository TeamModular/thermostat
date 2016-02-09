using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour 
{
	Light source;
	// Use this for initialization
	void Start () 
	{
		source  = GetComponentInChildren<Light>();
	}

	public void OnMouseDown()
	{
		Toggle ();
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
