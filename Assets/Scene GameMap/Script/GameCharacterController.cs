using UnityEngine;
using System.Collections;

public class GameCharacterController : MonoBehaviour {


    private GameCharacter _character;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public GameCharacter character
    {
        get { return _character; }
        set { _character = value; }
    }
}