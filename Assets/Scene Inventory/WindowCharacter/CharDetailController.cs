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
        GameAttributes _attr = new GameAttributes();
        _attr = _char.attributes;
        if (_char.leftArm != null)
        {
            _attr.agility += _char.leftArm.attributes.agility;
            _attr.alchemy += _char.leftArm.attributes.alchemy;
            _attr.endurance += _char.leftArm.attributes.endurance;
            _attr.strength += _char.leftArm.attributes.strength;
            _attr.technology += _char.leftArm.attributes.technology;
        }
        if (_char.rightArm != null)
        {
            _attr.agility += _char.rightArm.attributes.agility;
            _attr.alchemy += _char.rightArm.attributes.alchemy;
            _attr.endurance += _char.rightArm.attributes.endurance;
            _attr.strength += _char.rightArm.attributes.strength;
            _attr.technology += _char.rightArm.attributes.technology;
        }
        if (_char.leftLeg != null)
        {
            _attr.agility += _char.leftLeg.attributes.agility;
            _attr.alchemy += _char.leftLeg.attributes.alchemy;
            _attr.endurance += _char.leftLeg.attributes.endurance;
            _attr.strength += _char.leftLeg.attributes.strength;
            _attr.technology += _char.leftLeg.attributes.technology;
        }
        if (_char.rightLeg != null)
        {
            _attr.agility += _char.rightLeg.attributes.agility;
            _attr.alchemy += _char.rightLeg.attributes.alchemy;
            _attr.endurance += _char.rightLeg.attributes.endurance;
            _attr.strength += _char.rightLeg.attributes.strength;
            _attr.technology += _char.rightLeg.attributes.technology;
        }

        _agility.guiText.text = _attr.agility.ToString();
        _alchemy.guiText.text = _attr.alchemy.ToString();
        _endurance.guiText.text = _attr.endurance.ToString();
        _strength.guiText.text = _attr.strength.ToString();
        _technology.guiText.text = _attr.technology.ToString();

        _life.guiText.text = _attr.life.ToString();
        _money.guiText.text = _char.attributes.money.ToString();
    }

}
