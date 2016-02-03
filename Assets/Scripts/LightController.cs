using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	UnityEngine.Component lightSource;
	Light light;
	// Use this for initialization
	void Start () 
	{
		lightSource = GetComponent ("lightbulb");
		light = this.lightSource.GetComponent<Light> ();
	}

	public void OnMouseClick()
	{
		Toggle ();
	}

	private void Toggle() 
	{
		
		light.enabled = !light.enabled;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
