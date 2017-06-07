using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour {
	GameObject background;
	GameObject resumeButton;
	GameObject quitButton;

	void Awake() {
		background = this.transform.Find("background").gameObject;
		resumeButton = this.transform.Find("resume").gameObject;
		quitButton = this.transform.Find("quit").gameObject;
	}

	public void GamePause() {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		background.SetActive(true);
		resumeButton.SetActive(true);
		quitButton.SetActive(true);
	}

	public void GamePlay() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		background.SetActive(false);
		resumeButton.SetActive(false);
		quitButton.SetActive(false);
	}

	public void GameQuit() {
		Application.Quit();
	}
}
