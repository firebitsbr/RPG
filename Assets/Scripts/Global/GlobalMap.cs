using UnityEngine;
using System.Collections;

public class GlobalMap {

    private static ArrayList _itens;
    private static ArrayList _character;

	public static void Init() {
        _itens = new ArrayList();
        _character = new ArrayList();
	}

    public static void SaveCharacter(ArrayList character)
    {
        for(int i = 0; i < character.Count; i++) {
            _character.Add((character[i] as GameObject).GetComponent<GameCharacterController>().character);
        }
    }
    public static void SaveItens(ArrayList itens)
    {
        for (int i = 0; i < itens.Count; i++)
        {
            _itens.Add((itens[i] as GameObject).GetComponent<ItemBase>().item);
        }
    }
    public static ArrayList LoadCharacter()
    {
        return _character;
    }
    public static ArrayList LoadItens()
    {
        return _itens;
    }


}
