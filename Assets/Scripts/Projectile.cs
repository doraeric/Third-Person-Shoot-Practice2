using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour {
	[SerializeField]float speed;
	[SerializeField]float timeToLive;
	[SerializeField]float damage;

	void Start() {
		Destroy(gameObject, timeToLive);
	}

	void Update() {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

	void OnCollisionEnter(Collision collision) {
		Destroy(gameObject);
	}

	void OnTriggerEnter(Collider other) {
		Destroy(gameObject);
		var destructable = other.transform.GetComponent<Destructable>();
		if (destructable == null) {
			print("not destructable");
			return;
		}

		destructable.TakeDamege(damage);
	}
}
