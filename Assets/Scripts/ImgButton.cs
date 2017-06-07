using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImgButton : EventTrigger {
	protected GUIController guiController;
	void Awake() {
		Debug.Log("event trigger awake");
		guiController = GetComponentInParent<GUIController>();
	}

	public override void OnPointerClick(PointerEventData data) {
		Debug.Log("OnPointerClick called.");
	}

	public override void OnPointerEnter(PointerEventData data) {
		Debug.Log("OnPointerEnter called.");
	}

	public override void OnPointerExit(PointerEventData data) {
		Debug.Log("OnPointerExit called.");
	}
}
