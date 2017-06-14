using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePlayAudio : MonoBehaviour {
	public AudioSource audio;
	public AudioSource bgm;
	private GameObject player;

	void Awake() {
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			bgm.Stop ();
			audio.Play ();
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			audio.Stop ();
			bgm.Play ();
		}
	}
}
