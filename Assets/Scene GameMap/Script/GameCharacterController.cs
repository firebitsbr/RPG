using UnityEngine;
using System.Collections;

public class GameCharacterController : MonoBehaviour {


    private GameCharacter _character;
    public bool isPlayer = false;

	void Start () {
        if (isPlayer)
        {
            _character = GlobalCharacter.generetaChar();
            _character.sprite = Random.Range(1, 4);
        }
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