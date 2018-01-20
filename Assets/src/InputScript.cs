using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour {
    public string stringToEdit;
    private TouchScreenKeyboard keyboard;
    private TouchScreenKeyboardType keyboardType = TouchScreenKeyboardType.Default;

    // Opens native keyboard
    void OnGUI()
    {
        TouchScreenKeyboard.hideInput = true;
        stringToEdit = GUI.TextField(new Rect(10, 10, 200, 30), stringToEdit, 30);
        keyboard = TouchScreenKeyboard.Open(stringToEdit, keyboardType, false, false);
        
    }
}
