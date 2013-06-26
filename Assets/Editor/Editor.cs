using UnityEditor;
using UnityEngine;
using System.Collections;

public class Editor : EditorWindow {

    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;
    Vector2 _scroll = new Vector2();

    [MenuItem("Window/Database Example")]
    public static void ShowWindow()
    {
        //Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow(typeof(Editor));
    }

    void OnGUI()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Text Field", myString);

        float _width = (float)(Screen.width) * (float)(0.3);

        _scroll = EditorGUILayout.BeginScrollView(_scroll, GUILayout.Height(100), GUILayout.Width(Screen.width));
        for (int i = 0; i < 10; i++)
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("label 1", GUILayout.Width(_width));
            GUILayout.Label("label 2", GUILayout.Width(_width));
            GUILayout.Label("label 2", GUILayout.Width(_width));
            EditorGUILayout.EndHorizontal();
        }
        EditorGUILayout.EndScrollView();

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();
    }
}