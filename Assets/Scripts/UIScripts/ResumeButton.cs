using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResumeButton : ImgButton {
	public override void OnPointerClick(PointerEventData data) {
		base.OnPointerClick(data);
		guiController.GamePlay();
	}
}
