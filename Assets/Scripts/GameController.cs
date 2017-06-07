using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	[SerializeField]GameObject canvas;
	GUIController guiController;

	void Awake() {
		guiController = canvas.GetComponent<GUIController>();
	}

	void Start() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (Cursor.visible == false) {
				guiController.GamePause();
			} else {
				guiController.GamePlay();
			}
		}
	}
}
