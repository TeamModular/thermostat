using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour 
{
	Light source;
	AudioSource lightToggle;
	// Use this for initialization
	public float scale;
	void Awake()
	{
		source  = GetComponentInChildren<Light>();
		
		float mag = transform.localScale.magnitude;

		
		Vector3 newScale = new Vector3(scale*transform.localScale.y / mag, scale*transform.localScale.x / mag, scale*transform.localScale.z / mag);
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
