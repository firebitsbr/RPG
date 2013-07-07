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
        Debug.Log("remove equiped");
        GameItem itm = _windowChar.currentItemSelected;
        
        switch (_windowChar.itemSelected)
        {
            case ItemType.Alchemy:
                Debug.Log(_windowChar.itemNumSelected);
                GlobalCharacter.player.RemoveEquippedItem(itm, _windowChar.itemNumSelected);

                break;
            case ItemType.Equipment:
                GlobalCharacter.player.RemoveEquippedEquipment(itm.equipmentType);

                break;
        }

        Camera.main.GetComponent<InventoryController>().UpdateCharacter();

    }
}