using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject _hud;
    public GameObject _chat;

	void Start () {
        GlobalItens.Init();
        GlobalCharacter.Init();
        GlobalWorldMap.Init();
        GlobalQuests.Init();
	}
	
	// Update is called once per frame
	void Update () {
	
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
