using UnityEngine;
using System.Collections;

public class GlobalCharacter {

    private static GameCharacter[] _party = new GameCharacter[3];
    private static GameCharacter[] _npcs;
	

	void Init() {

        _party[0] = generetaChar();
        _party[1] = generetaChar();
        _party[2] = generetaChar();

	}

    private static GameCharacter generetaChar()
    {
        GameCharacter _char = new GameCharacter();
        _char.attributes = new GameAttributes();
        _char.attributes.SetAttributes(10, 10, 10, 10, 10, 100, 10, 1000);


        return _char;
    }

    public static GameCharacter[] party
    {
        get { return _party; }
        set { _party = value; }
    }
    public static GameCharacter[] npcs
    {
        get { return _npcs; }
        set { _npcs = value; }
    }
}
