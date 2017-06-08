using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	[SerializeField]float rateOfFire;
	[SerializeField]Projectile projectile;

	[HideInInspector]
	public Transform muzzle;

	float nextFireAllowed;
	protected bool canFire;
	private LineRenderer laserLine;

	void Awake() {
		muzzle = transform.Find("Muzzle");
		laserLine = GetComponent<LineRenderer>();
	}

	public virtual void Fire() {
		canFire = false;
		if (Time.time < nextFireAllowed)
			return;
		nextFireAllowed = Time.time + rateOfFire;

		Instantiate(projectile, muzzle.position, muzzle.rotation);
		canFire = true;
	}

	public virtual void showRaycast(bool show) {
		if (!show) {
			laserLine.enabled = false;
			return;
		}
		laserLine.enabled = true;
		Vector3 direction = muzzle.transform.forward;
		direction *= 100;
		laserLine.SetPosition(0, muzzle.position);
		laserLine.SetPosition(1, muzzle.position + direction);

		/*
		RaycastHit hit;
		if (Physics.Raycast(muzzle.position, direction, out hit, 100)) {
			Debug.Log("hit: " + hit.transform.name);
			Collider[] colliders = hit.transform.GetComponentsInChildren<Collider>();
			Debug.Log("how many colliders: " + colliders.Length);
			if (hit.transform.GetComponent<Collider>() == null) {
				Debug.Log("has no collider?");
			}
		}*/
	}
}