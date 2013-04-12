using UnityEngine;
using System.Collections;

public class example : MonoBehaviour {
    public string stringToEdit = "Hello World\nI've got 2 lines...";
    void OnGUI() {
        stringToEdit = GUI.TextArea(new Rect(10, 10, 200, 100), stringToEdit, 200);
    }
}