using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GlobalItens.Init();
        GlobalCharacter.Init();
        GlobalWorldMap.Init();
        GlobalQuests.Init();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
