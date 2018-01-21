using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
//   public Dictionary charComplexity; 
//   // Maps a character to how hard it would be to type on a mobile 
//    // screen
    
//    public int score;
//    public int combo;
//    public int accuracy;
//    public int multiplierValue;
//    
//    public bool isPaused;
//
//    public List<string> gameWords;
//    public List<TextBlob> gameBlobs;

	// Use this for initialization
	void Start () {
	}
    
	// Update is called once per frame
    void Update () {

    }
	
//    // Takes in mobileinput
//	void onSpace() {
//        string playerInput = " ";
//        for (int i = 0; i < 4; i++) {
//             if(playerInput == gameBlobs[i].getText()) {
//                updateScore(gameBlobs[i]);
//                updateStats(gameBlobs[i]);
//
//                updateBlobs(i); // Should Generate a New Blob in place of completed blob
//                boostMultipliers();
//                return;
//             }
//        }
//
//        // If loop does not terminate, player has not typed in a valid input
//        // In this case reset multipliers, and deduct points
//        multiplierValue = 1;
//	}
//
//    // Adds points to current score based on:
//    //   * Length of text completed
//    //   * Whether or not is a special text blob
//    //   * Complexity of Word
//    //   * Combo and Multipliers
//    void updateScore(TextBlob finishedTextBlob) {
//        score += multiplierValue * finishedTextBlob.getText().Length;
//        score += calculateWordComplexity(finishedTextBlob.getText());
//        if(finishedTextBlob.GetType() == SpecialTextBlob) {
//            score += finishedTextBlob.bonus; 
//        }
//    }
//
//    // A word complexity score represents how difficult it is to type a
//    // certain word on a touch screen.
//    void calculateWordComplexity() { };
//    
//    void boostMultipliers() {
//        if(multiplierValue == 16) {
//            return;
//        }  else {
//            multiplierValue *= 2;
//        } 
//    }
//    
//    
}
