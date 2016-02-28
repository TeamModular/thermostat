using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public GameObject PauseCanvas;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("escape"))
        {
            GameManager.Instance.SetPause(!GameManager.Instance.Paused);
            PauseCanvas.SetActive(GameManager.Instance.Paused);
        }

	}
}
