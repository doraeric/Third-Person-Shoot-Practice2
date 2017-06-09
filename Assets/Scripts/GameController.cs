using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	void Start() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (Cursor.visible == false) {
				UIManager.Instance.ShowPanel("PausePanel");
				//guiController.GamePause();
			} else {
				//guiController.GamePlay();
				UIManager.Instance.ClosePanel("PausePanel");
			}
		}
	}
}
