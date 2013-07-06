using UnityEngine;
using System.Collections;

public class GameCharacterController : MonoBehaviour {


    private GameCharacter _character;

	void Start () {
        _character = GlobalCharacter.generetaChar();
        _character.name = "NPC Teste";
        _character.sprite = Random.Range(1, 4);
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