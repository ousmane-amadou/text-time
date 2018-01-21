using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class TextBlob {
/* Representation Invariants */
// 0 < text.length <= 6
    private string text;      // the text held in this blob
	private string typedText; // What has been typed while this blob was selected
    public bool isActive;  // This determines wether this word is being typed
    
    public List<GameObject> renderedCharacters; 
	public static List<string> words = new List<string>();

    // Represents the  graphical representation of each character in the 
    // text blob 
    
	public TextBlob() {

		if (words.Count == 0) {
			// Get a word
			string path = "Assets/resources/words.txt";

			//Read the text from directly from the test.txt file
			StreamReader reader = new StreamReader (path); 

			for (int j = 0; j < 500; j++) {
				int randomNumber = Random.Range (1, 10000);
				for (int i = 0; i < randomNumber; i++) {
					if (i == randomNumber - 1) {
						words.Add (reader.ReadLine ());
					}
				}
			}
			reader.Close ();
		}

		int randomIndex = Random.Range (0, words.Count);
		this.text = words[randomIndex];

        this.typedText = "";
        this.isActive = false;
	}
    
    //public string getNextCharacter() {
    
    //}
    
    
	//// Called once per frame
	//void FixedUpdate() {
	//	// Update typed word
	//	updateTypedWord(Input.inputString);

	//	// Update UI: Compare the chars at each index, if equal green, else red.
	//	for (int i = 0; i < typedText.Length; i++) {
	//		if (this.word.text.ToCharArray()[i].Equals(this.typedText.ToCharArray()[i])) {
	//			// Make green
	//			this.word.color = new Color(0, 1f, 0);

	//		} else {
	//			// Make red
	//			this.word.color = new Color(1f, 0, 0);
	//		}
	//	}
	//}


	//// Client calls this to update word progress.
	//void updateTypedWord(string typedString) {
	//	this.typedText += typedString;

	//	if (typedString.Contains(" ")) {// User entered space
	//		// notify the game object of stats
	//		// such as timeLeft, typedText,
	//		// word and the fact that we died.
	//		return;
	//	}
	//}
}
