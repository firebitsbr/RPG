using UnityEngine;
using System.Collections;

public class CharDetailController : MonoBehaviour {


    public GameObject _agility;
    public GameObject _alchemy;
    public GameObject _endurance;
    public GameObject _strength;
    public GameObject _technology;

    public GameObject _life;
    public GameObject _money;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void UpdateCharDetail()
    {

        _agility.guiText.text = GlobalCharacter.player.attributes.agility.ToString();
        _alchemy.guiText.text = GlobalCharacter.player.attributes.alchemy.ToString();
        _endurance.guiText.text = GlobalCharacter.player.attributes.endurance.ToString();
        _strength.guiText.text = GlobalCharacter.player.attributes.strength.ToString();
        _technology.guiText.text = GlobalCharacter.player.attributes.technology.ToString();

        _life.guiText.text = GlobalCharacter.player.attributes.life.ToString();
        _money.guiText.text = GlobalCharacter.player.attributes.money.ToString();
    }

}
