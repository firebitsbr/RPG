using UnityEngine;
using System.Collections;

public class GlobalCharacter {

    private static GameCharacter[] _party = new GameCharacter[3];
    private static ArrayList _npcs;
    private static ArrayList _enemies;
    private static bool _hasInit = false;

	public static void Init() {

        if (!_hasInit)
        {
            _party[0] = generetaChar();
            _party[0].name = "Character 1";
            _party[0].sprite = 1;

            _party[1] = generetaChar();
            _party[1].name = "Character 2";
            _party[0].sprite = 2;

            _party[2] = generetaChar();
            _party[2].name = "Character 3";
            _party[0].sprite = 3;

            _npcs = new ArrayList();
            _enemies = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                _enemies.Add(generetaChar());
            }
            _hasInit = true;
        }
	}

    public static GameCharacter generetaChar()
    {
        GameCharacter _char = new GameCharacter();
        _char.attributes = new GameAttributes();
        _char.attributes.SetAttributes(10, 10, 10, 10, 10, 100, 50, 10, 1000);


        _char.itens.SetValue(GlobalItens.generateAlchemy(AlchemyType.HealLife), 0);
        _char.itens.SetValue(GlobalItens.generateAlchemy(AlchemyType.HealLife), 1);
        _char.itens.SetValue(GlobalItens.generateAlchemy(AlchemyType.HealLife), 2);
        _char.itens.SetValue(GlobalItens.generateAlchemy(AlchemyType.HealLife), 3);


        GameSkill _atk = new GameSkill();
        _atk.SetAttributes("attack", "desc", 10, TargetTypes.AllEnemies, TargetAttribute.Life);
        GameSkill _spe = new GameSkill();
        _spe.SetAttributes("Special", "desc", 10, TargetTypes.All, TargetAttribute.Life);

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
    public static ArrayList npcs
    {
        get { return _npcs; }
        set { _npcs = value; }
    }
    public static ArrayList enemies
    {
        get { return _enemies; }
        set { _enemies = value; }
    }
}
