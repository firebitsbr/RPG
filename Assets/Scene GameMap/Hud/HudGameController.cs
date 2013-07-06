using UnityEngine;
using System.Collections;

public class HudGameController : MonoBehaviour {

    public GameObject _buttonExit;
    public GameObject _buttonInventory;
    public GameObject _text;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShowText(string value)
    {
        _text.GetComponent<GUIText>().text = value;
    }
}
