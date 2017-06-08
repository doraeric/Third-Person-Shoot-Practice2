using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImgButton : EventTrigger {
	protected GUIController guiController;
	void Awake() {
		guiController = GetComponentInParent<GUIController>();
	}

	public override void OnPointerClick(PointerEventData data) {
		Image img = GetComponent<Image>();
		img.color = new Color32(206, 206, 206, 206);
	}

	public override void OnPointerEnter(PointerEventData data) {
		Image img = GetComponent<Image>();
		img.color = new Color32(100, 100, 255, 206);
	}

	public override void OnPointerExit(PointerEventData data) {
		Image img = GetComponent<Image>();
		img.color = new Color32(206, 206, 206, 206);
	}
}
