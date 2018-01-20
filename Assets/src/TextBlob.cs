using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TextBlob {
	private string typedText = "";// What has been typed while this blob was selected
	public bool isActive = false;// This determines wether this word is being typed
	public Text word;// The word in this blob

	// Init
	void Start() {
		// Get word from GameObject's store
	}

	// Called once per frame
	void FixedUpdate() {
		// Update typed word
		updateTypedWord(Input.inputString);

		// Update UI: Compare the chars at each index, if equal green, else red.
		for (int i = 0; i < typedText.Length; i++) {
			if (this.word.text.ToCharArray()[i].Equals(this.typedText.ToCharArray()[i])) {
				// Make green
				this.word.color = new Color(0, 1f, 0);

			} else {
				// Make red
				this.word.color = new Color(1f, 0, 0);
			}
		}
	}


	// Client calls this to update word progress.
	void updateTypedWord(string typedString) {
		this.typedText += typedString;

		if (typedString.Contains(" ")) {// User entered space
			// notify the game object of stats
			// such as timeLeft, typedText,
			// word and the fact that we died.
			return;
		}
	}
}