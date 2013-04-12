using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {
    public string stringToEdit = "Hello World\nI've got 2 lines...";
	int width = Screen.width;
	int height = Screen.height;
    void OnGUI() {
        stringToEdit = GUI.TextArea(new Rect(0, height- height/4, width, height), stringToEdit, 200);
    }
}