using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WinLoseManager : MonoBehaviour {

    public TimeManager TimeManager;
    public List<HappinessManager> HappinessManagers;
    public GameObject WinCanvas;
    public GameObject LossCanvas;
	
	// Update is called once per frame
	void Update () {
        // - Check win -
        // We want to check to see what time it is and if it is > 24:00 then the player has won.
        if (TimeManager.Hours > 23)
        {
            // Yay the player won!
            Time.timeScale = 0.0f;
            WinCanvas.SetActive(true);
        }

        // - Check loss -
        // We want to check to see if happiness is <= 0 and if so then you loooooseee!
        foreach (HappinessManager hapManager in HappinessManagers)
        {
            if (hapManager.happinessValue <= 0.0f)
            {
                Time.timeScale = 0.0f;
                LossCanvas.SetActive(true);
            }
        }
        
    }
}
