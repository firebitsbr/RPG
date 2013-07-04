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
            int curr = _charController.GetComponent<WindowCharacterController>().currentCharacterSelected;
            switch(itm.type) {
                case ItemType.Alchemy:
                    GlobalCharacter.party[curr].EquipItem(itm);
                    break;
                case ItemType.Equipment:
                    GlobalCharacter.party[curr].EquipEquipment(itm, itm.equipmentType);
                    break;
            }
        }
    }
}
