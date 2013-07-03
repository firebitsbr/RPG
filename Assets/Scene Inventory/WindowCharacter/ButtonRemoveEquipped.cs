using UnityEngine;
using System.Collections;

public class ButtonRemoveEquipped : MonoBehaviour {

    private WindowCharacterController _windowChar;

	void Start () {

        _windowChar = GameObject.Find("WindowCharacter").GetComponent<WindowCharacterController>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        // _windowChar.
        GameItem itm = _windowChar.currentItemSelected;
        switch (itm.type)
        {
            case ItemType.Alchemy:
                GlobalCharacter.party[_windowChar.currentCharacterSelected].RemoveEquippedItem(itm);
                break;
            case ItemType.Equipment:
                GlobalCharacter.party[_windowChar.currentCharacterSelected].RemoveEquippedEquipment(itm.equipmentType);
                break;
        }
    }
}