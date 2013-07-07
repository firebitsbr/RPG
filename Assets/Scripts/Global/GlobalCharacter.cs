using UnityEngine;
using System.Collections;

public class GlobalCharacter {

    private static GameCharacter _player;
    private static ArrayList _npcs;
    private static ArrayList _enemies;
    private static bool _hasInit = false;

	public static void Init() {

        if (!_hasInit)
        {
            _player = generetaChar();
            _player.name = "Character 1";
            _player.sprite = 1;

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
        _char.baseAttr.SetAttributes(10, 10, 10, 10, 10, 100, 1000);
        _char.baseAttr.SetTimers(10, 20, 5, 10);
        _char.sprite = Random.Range(1, 5);

        _char.itens.SetValue(GlobalItens.generateAlchemy(AlchemyType.HealLife), 0);
        _char.itens.SetValue(GlobalItens.generateAlchemy(AlchemyType.HealLife), 1);
        _char.itens.SetValue(GlobalItens.generateAlchemy(AlchemyType.HealLife), 2);
        _char.itens.SetValue(GlobalItens.generateAlchemy(AlchemyType.HealLife), 3);

        return _char;
    }

    public static GameCharacter player
    {
        get { return _player; }
        set { _player = value; }
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