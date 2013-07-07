using UnityEngine;
using System.Collections;

public class ButtonConfirmChangeEquipment : MonoBehaviour {

    public GameObject _charController;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GameItem itm = (_charController.GetComponent<WindowCharacterController>().currentItemSelected);

        if (GlobalItens.isInInventory(itm))
        {
            switch(itm.type) {
                case ItemType.Alchemy:
                    GlobalCharacter.player.EquipItem(itm);
                    break;
                case ItemType.Equipment:
                    GlobalCharacter.player.EquipEquipment(itm, itm.equipmentType);
                    break;
            }
        }
        _charController.GetComponent<WindowCharacterController>().HideListToEquip();
        _charController.GetComponent<WindowCharacterController>().OpenChangeItem(false);
        Camera.main.GetComponent<InventoryController>().UpdateCharacter();
    }
}