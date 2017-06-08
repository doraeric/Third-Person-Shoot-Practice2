using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

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
		Image img = GetComponent<Image>();
		if (img != null && img.isActiveAndEnabled)
			img.color = new Color32(100, 100, 255, 206);
	}

	public override void OnPointerExit(PointerEventData data) {
		Debug.Log("OnPointerExit called.");
		Image img = GetComponent<Image>();
		if (img != null && img.isActiveAndEnabled)
			img.color = new Color32(206, 206, 206, 206);
	}
}
