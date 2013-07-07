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
    public void UpdateCharDetail(GameCharacter _char)
    {

        _agility.guiText.text = _char.attributes.agility.ToString();
        _alchemy.guiText.text = _char.attributes.alchemy.ToString();
        _endurance.guiText.text = _char.attributes.endurance.ToString();
        _strength.guiText.text = _char.attributes.strength.ToString();
        _technology.guiText.text = _char.attributes.technology.ToString();

        _life.guiText.text = _char.attributes.life.ToString();
        _money.guiText.text = _char.attributes.money.ToString();
    }

}
