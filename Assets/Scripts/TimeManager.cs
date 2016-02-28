using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour
{

    public Text timeText;
    public float timeScaler = 1;

    public float currentTime = 86400;

    public int Hours
    {
        // Hours is number of seconds divided by 3600 rounded down
        get { return Mathf.FloorToInt(currentTime / 3600.0f); }
    }
	public int Minutes
    {
        // Minutes is number of seconds divided by 60, rounded down, modulo 60
        get { return Mathf.FloorToInt(currentTime / 60.0f) % 60; }
    }

    // Use this for initialization
    void Start()
    {
        // currentTime = 86400;
    }

    // Update is called once per frame
    void Update()
    {
        // Errors in deltaTime will cause the ingame clock to not quite run at realtime, but we don't want it to anyway.
        currentTime -= Time.deltaTime * timeScaler;

        timeText.text = string.Format("{0:00}:{1:00}", Hours, Minutes);
    }


}

