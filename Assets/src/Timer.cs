using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

	public float timeLeft = 60.0f;// Default is 1 minute.
	public Text timer;

	// Use this for initialization
	void Start () {
		// Update Timer UI
		timer.text = timeLeft.ToString();
	}

	// Update is called once per frame
	void Update () {
		// Update time left
		this.timeLeft -= Time.deltaTime;

		// Update Timer UI
		timer.text = timeLeft.ToString().Substring(0, 4);

		// End game
		if (this.timeLeft <= 0) {
			// Update UI
		}
	}
}
