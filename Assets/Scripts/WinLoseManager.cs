using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WinLoseManager : MonoBehaviour {

    public TimeManager TimeManager;
    public List<HappinessManager> HappinessManagers;
    public GameObject WinCanvas;
    public GameObject LossCanvas;
    public GameObject ScoreBreakdownCanvas;
    public EnergyManager energyManager;
    public Text RemainingHappinessText;
    public Text RemainingEnergyText;
    public string levelname;
	
    void DisplayScoreBreakdown()
    {
        ScoreBreakdownCanvas.SetActive(true);
        RemainingEnergyText.text = ((int)energyManager.energy).ToString();

        double totalHappinessLeft = 0.0;
        foreach (HappinessManager hapManager in HappinessManagers)
        {
            totalHappinessLeft += hapManager.happinessValue;
        }
        RemainingHappinessText.text = totalHappinessLeft > 0 ? totalHappinessLeft.ToString() : "0";

    }

	// Update is called once per frame
	void Update () {
        // - Check win -
        // We want to check to see what time it is and if it is > 24:00 then the player has won.
		if (TimeManager.Hours <= 0 && TimeManager.Minutes <= 0)
        {
            // Yay the player won!
            Time.timeScale = 0.0f;
            WinCanvas.SetActive(true);
            DisplayScoreBreakdown();
	        PlayerPrefs.SetInt(levelname,1);
        }

        // - Check loss -
        // We want to check to see if happiness is <= 0 and if so then you loooooseee!
        foreach (HappinessManager hapManager in HappinessManagers)
        {
            if (hapManager.happinessValue <= 0.0f)
            {
                Time.timeScale = 0.0f;
                LossCanvas.SetActive(true);
                DisplayScoreBreakdown();
            }
        }
        
    }
}
