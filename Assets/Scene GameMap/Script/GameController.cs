using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject _hud;
    public GameObject _chat;

    private ArrayList _itens;
    private ArrayList _npcs;

    public GameObject CharacterModel;
    public GameObject ItemModel;
    public GameObject PlayerModel;


	void Start () {
        GlobalItens.Init();
        GlobalCharacter.Init();
        GlobalWorldMap.Init();
        GlobalQuests.Init();
        GlobalMap.Init();
        GlobalInput.Init();

        _itens = new ArrayList();
        _npcs = new ArrayList();

        AddItemToMap(GlobalItens.generateAlchemy(AlchemyType.HealLife), new Vector3(64,96,-5));


        GameCharacter test = GlobalCharacter.generetaChar();
        test.name = "ERRROR";
        test.sprite = 5;

        AddCharacterToMap(test, new Vector3(32,32,-10));
	}

    public void RemoveItem(GameObject itm)
    {

    }
    public void RemoveNPC(GameObject npc)
    {

    }

    public void AddItemToMap(GameItem itm, Vector3 pos)
    {
        GameObject item = Instantiate(ItemModel, pos, Quaternion.identity) as GameObject;
        _itens.Add(item);
        item.GetComponent<ItemBase>().item = itm;

    }
    public void AddCharacterToMap(GameCharacter value, Vector3 pos)
    {
        GameObject gamChar = Instantiate(CharacterModel, pos, Quaternion.identity) as GameObject;
        _npcs.Add(gamChar);
        gamChar.GetComponent<GameCharacterController>().character = value;
    }

    public void SaveData()
    {
        GlobalMap.SaveCharacter(_npcs);
        GlobalMap.SaveItens(_itens);
    }

    public void ShowTooltip(string value)
    {
        _hud.GetComponent<HudGameController>().ShowText(value);
    }

    public void ShowChat()
    {
        _chat.GetComponent<ChatController>().Init();
    }
}
