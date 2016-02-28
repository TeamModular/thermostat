using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {

    public GameObject PauseCanvas;

    public void SetPauseMenuActive(bool active)
    {
        GameManager.Instance.SetPause(active);
        PauseCanvas.SetActive(active);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("escape"))
        {
            SetPauseMenuActive(!GameManager.Instance.Paused);
        }
	}
}
