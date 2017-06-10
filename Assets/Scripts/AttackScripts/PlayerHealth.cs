using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Destructable {
	public override void Die() {
		// base.Die();

		// call ui
		Application.Quit();
	}
}
