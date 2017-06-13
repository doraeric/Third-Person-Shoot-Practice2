using UnityEngine;
using System.Collections;

public class auto_laugh : MonoBehaviour
{
	public AudioSource efxSource;                   //Drag a reference to the audio source which will play the sound effects.
	//public static SoundManager instance = null;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}


	public string message = "";


	private GameObject player;
	private bool used = false;

	private ControlsTutorial manager;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");

	}


	void OnTriggerEnter(Collider other)
	{
		if((other.gameObject == player) && !used)
		{
			efxSource.Play ();
			used = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject == player)
		{
			efxSource.Stop();
			Destroy(gameObject);
		}
	}
}