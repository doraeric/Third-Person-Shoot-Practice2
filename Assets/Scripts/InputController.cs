using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
	/*public float Vertical;
	public float Horizontal;
	public Vector2 MouseInput;
	public bool Fire1;

	void Update () {
		Vertical = Input.GetAxis("Vertical");
		Horizontal = Input.GetAxis("Horizontal");
		MouseInput = new Vector2(Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));
		Fire1 = Input.GetButton("Fire1");
	}*/

	public bool GetButtonDown(string name) {
		if (UIManager.Instance.IsClear()) {
			return Input.GetButtonDown(name);
		} else {
			return false;
		}
	}

	public bool GetButton(string name) {
		if (UIManager.Instance.IsClear()) {
			return Input.GetButton(name);
		} else {
			return false;
		}
	}

	public float GetAxis (string name) {
		if (UIManager.Instance.IsClear()) {
			return Input.GetAxis(name);
		} else {
			return 0.0f;
		}
	}
}
