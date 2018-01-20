using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour {
    public string stringToEdit = "Hello World";
    private TouchScreenKeyboard keyboard;

    // Opens native keyboard
    void OnGUI()
    {
        stringToEdit = GUI.TextField(new Rect(10, 10, 200, 30), stringToEdit, 30);
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        Debug.Log(TouchScreenKeyboard.visible);
    }
}
