using UnityEngine;
using System.Collections;

public class WinLoseManager : MonoBehaviour {

    public TimeManager TimeManager;
    public HappinessManager HappinessManager;
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
        if(HappinessManager.happinessValue <= 0.0f)
        {
            Time.timeScale = 0.0f;
            LossCanvas.SetActive(true);
        }
        
    }
}
