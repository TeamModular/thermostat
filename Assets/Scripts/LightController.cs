using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour 
{
	Light source;
	AudioSource lightToggle;
	// Use this for initialization

	void Awake()
	{
		source  = GetComponentInChildren<Light>();

		Vector3 newScale = new Vector3(transform.localScale.y, transform.localScale.x, transform.localScale.z);
		source.transform.localScale = newScale;

	}

	void Start () 
	{
		


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
