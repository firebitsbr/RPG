using UnityEngine;
using System.Collections;

public class GlobalCharacter {

    private static GameCharacter[] _party = new GameCharacter[3];
    private static GameCharacter[] _npcs;
	

	public static void Init() {

        _party[0] = generetaChar();
        _party[1] = generetaChar();
        _party[2] = generetaChar();

	}

    private static GameCharacter generetaChar()
    {
        GameCharacter _char = new GameCharacter();
        _char.attributes = new GameAttributes();
        _char.attributes.SetAttributes(10, 10, 10, 10, 10, 100, 10, 1000);

        GameItem itm = new GameItem();
        itm.setAttributes("item", "desc", 10, 10);

        _char.itens.SetValue(itm, 0);
        _char.itens.SetValue(itm, 1);
        _char.itens.SetValue(itm, 2);
        _char.itens.SetValue(itm, 3);


        GameSkill _atk = new GameSkill();
        _atk.SetAttributes("attack", "desc", 10, TargetTypes.Enemy, TargetAttribute.Life);
        GameSkill _spe = new GameSkill();
        _spe.SetAttributes("Special", "desc", 10, TargetTypes.Enemy, TargetAttribute.Life);

        _char.attacks.SetValue(_atk, 0);
        _char.attacks.SetValue(_atk, 1);
        _char.attacks.SetValue(_atk, 2);
        _char.attacks.SetValue(_atk, 3);

        _char.specials.SetValue(_spe, 0);
        _char.specials.SetValue(_spe, 1);
        _char.specials.SetValue(_spe, 2);

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
