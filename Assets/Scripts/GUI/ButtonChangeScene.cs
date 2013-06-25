using UnityEngine;
using System.Collections;

public class ButtonChangeScene : MonoBehaviour {

	// Use this for initialization
    public string _sceneName;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && guiTexture.HitTest(Input.mousePosition))
        {
            Application.LoadLevel(_sceneName);
        }
	}
}
