using UnityEngine;
using System.Collections;

public class TutorialManager : MonoBehaviour {

    public GameObject mainCamera;
    public GameObject maxCamera;
    public GameObject mainCanvas;
    public GameObject pauseManager;

	// Use this for initialization
	void Start () {
        GameManager.Instance.SetPause(true);
	}

    public void MoveToTutorialStep2()
    {
        maxCamera.SetActive(false);
        mainCamera.SetActive(true);
        mainCanvas.SetActive(true);
    }

    public void BeginGame()
    {
        pauseManager.SetActive(true);
        GameManager.Instance.SetPause(false);
    }

}
