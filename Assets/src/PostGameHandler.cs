using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PostGameHandler : MonoBehaviour {
	public int score = 20;
	public float accuracy = 50.0f;
	public int wordsTyped = 100;

	public Text statslabel;
	public Button playButton;

	// Use this for initialization
	void Start () {
		TextBlob t = new TextBlob ();

		statslabel.text = "Score: " + score.ToString () + "\n Words Typed: " + wordsTyped.ToString()
			+ "\n Accuracy: ";

		if (accuracy.ToString().Length > 5) {
			statslabel.text += accuracy.ToString().Substring (0, 5);

		} else {
			statslabel.text += accuracy.ToString();
		}

		playButton.onClick.AddListener (loadGameScene);
	}
	
	// Update is called once per frame
	void loadGameScene () {
		SceneManager.LoadScene ("game");
	}
}
