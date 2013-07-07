using UnityEngine;
using System.Collections;

public class CharacterSelector : MonoBehaviour {

    public int _next;
    private WindowCharacterController _windowChar;

	void Start () {
        _windowChar = GameObject.Find("/WindowCharacter").GetComponent<WindowCharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        int curr = _windowChar.currentCharacterSelected + _next;
        if (curr > 2)
        {
            curr = 0;
        }
        if (curr < 0)
        {
            curr = 2;
        }

        _windowChar.LoadCharDetail(curr);

    }
}
