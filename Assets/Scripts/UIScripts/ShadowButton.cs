using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowButton : MonoBehaviour {
	public void OnBtnClick() {
		UIManager.Instance.TogglePanel("WeaponWheel", false);
	}
}
