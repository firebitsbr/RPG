using UnityEngine;
using System.Collections;

public class CharEquippedController : MonoBehaviour {

    public GameObject _LeftLeg;
    public GameObject _RightLeg;

    public GameObject _LeftArm;
    public GameObject _RightArm;

    // @TODO: update character detail


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addEquipment(GameItem equipment)
    {

        removeEquipment(equipment.equipmentType);

        GameObject itm = null;
        switch (equipment.equipmentType)
        {
            case EquipmentType.LeftArm:
                itm = _LeftArm;
                break;
            case EquipmentType.LeftLeg:
                itm = _LeftLeg;
                break;
            case EquipmentType.RightArm:
                itm = _RightArm;
                break;
            case EquipmentType.RightLeg:
                itm = _RightLeg;
                break;
        }

        ItemSlotController gamItm = (itm.GetComponent("ItemSlotController") as ItemSlotController);
        gamItm.addToSlot(equipment);

    }

    void removeEquipment(EquipmentType type)
    {
        GameObject itm = null;
        switch (type)
        {
            case EquipmentType.LeftArm:
                itm = _LeftArm;
                break;
            case EquipmentType.LeftLeg:
                itm = _LeftLeg;
                break;
            case EquipmentType.RightArm:
                itm = _RightArm;
                break;
            case EquipmentType.RightLeg:
                itm = _RightLeg;
                break;
        }
        ItemSlotController gamItm = (itm.GetComponent("ItemSlotController") as ItemSlotController);

        // add item equipped to inventory
        (GameObject.Find("/WindowItem/BoxListItens").GetComponent("ListItensController") as ListItensController).addItem(gamItm.item);
        // remove equipped item from slot
        gamItm.removeItem();
    }
}
