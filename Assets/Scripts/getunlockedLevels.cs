using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class getunlockedLevels : MonoBehaviour {

	private List<string> mylist;
	public Button level1;
	public Button level2;
	public Button level3;
	
	// Use this for initialization
	void Start () 
	{
		mylist = new List<string>(new string[] { "level1", "level2", "level3" });
		populateKeys();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Button button = level1.GetComponent<Button>();
		button.interactable = getLockedState("level1");
		button = level2.GetComponent<Button>();
		button.interactable = getLockedState("level2");
		button = level3.GetComponent<Button>();
		button.interactable = getLockedState("level3");
	}

	void populateKeys()
	{
		foreach(string key in mylist)
		{
			print(key);
			if (!PlayerPrefs.HasKey(key))
			{
				print("missing");
				PlayerPrefs.SetInt(key,0);
			}
			else
			{
				print("found");
				print(PlayerPrefs.GetInt(key));
			}
		}
	}
	
	bool getLockedState(string key)
	{
		if (PlayerPrefs.GetInt(key)==0)
			return false;
		else
			return true;
	}

}
