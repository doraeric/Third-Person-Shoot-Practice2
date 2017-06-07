using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	void Start() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (Cursor.visible == false) {
				Debug.Log("change to visible");
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			} else {
				Debug.Log("change to invisible");
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			}
		}
	}
}
