using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour {
    public string stringToEdit = "Hello World";
    private TouchScreenKeyboard keyboard;

    void OnGUI()
    {   
        stringToEdit = GUI.TextField(new Rect(10, 10, 200, 30), stringToEdit, 30);
        keyboard = TouchScreenKeyboard.Open(stringToEdit, TouchScreenKeyboardType.Default);
        //foreach (Touch touch in Input.touches)
        //{
        //    string message = "";
        //    message += "ID: " + touch.fingerId + "\n";
        //    message += "Phase: " + touch.phase.ToString() + "\n";
        //    message += "TapCount: " + touch.tapCount + "\n";
        //    message += "Pos X: " + touch.position.x + "\n";
        //    message += "Pos Y: " + touch.position.y + "\n";

        //    int num = touch.fingerId;
        //    GUI.Label(new Rect(0 + 130*num, 0, 120, 100), message);
        //}    
    }
}
