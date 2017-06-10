using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Shooter))]
public class TurretShoot : MonoBehaviour {

	[SerializeField]float detectDist = 10;

	Shooter weapon;
	void Awake() {
		weapon = GetComponent<Shooter>();
	}
	void Update () {
		var player = GameManager.Instance.LocalPlayer;
		Transform target = player.transform.Find("Center").transform;
		if (target == null)
			target = player.transform;
		
		float dist = Vector3.Distance(target.position, transform.position);
		if (dist < detectDist) {
			Vector3 relativePos = target.position - transform.position;
			Quaternion toRotation = Quaternion.LookRotation(relativePos);
			// transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.time * 0.1f);
			transform.rotation = toRotation;
			weapon.Fire();
		}
	}
}
