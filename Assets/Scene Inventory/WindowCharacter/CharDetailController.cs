using UnityEngine;
using System.Collections;

public class CharDetailController : MonoBehaviour {


    private GameAttributes _character;

    // @TODO: load data from global player


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void UpdateCharDetail()
    {
        GameObject detail = GameObject.Find("/WindowCharacter/BoxCharDetail");

        (detail.GetComponent("Agility") as GUIText).text = _character.agility.ToString();
        (detail.GetComponent("Alchemy") as GUIText).text = _character.alchemy.ToString();
        (detail.GetComponent("Endurance") as GUIText).text = _character.endurance.ToString();
        (detail.GetComponent("Strength") as GUIText).text = _character.strength.ToString();
        (detail.GetComponent("Technology") as GUIText).text = _character.technology.ToString();

        (detail.GetComponent("Life") as GUIText).text = _character.life.ToString();
        (detail.GetComponent("Money") as GUIText).text = _character.money.ToString();
    }


    public GameAttributes character
    {
        get { return _character; }
        set { _character = value; }
    }
}
