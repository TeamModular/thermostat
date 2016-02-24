using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sliderColourChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Slider slider=GetComponent<Slider> ();	
		slider.image.color = Color.Lerp (Color.red, Color.green, slider.value);
	}
}
