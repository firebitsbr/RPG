using UnityEngine;
using System.Collections;

public class CharEquippedController : MonoBehaviour {

    public GameObject _LeftLeg;
    public GameObject _RightLeg;

    public GameObject _LeftArm;
    public GameObject _RightArm;

    public GameObject[] itens = new GameObject[4];


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void UpdateCharDetail(GameCharacter _char)
    {
        for (int i = 0; i < 4; i++)
        {
            if (_char.itens[i] != null)
            {
                addItem(_char.itens[i]);
            }
        }

        if (_char.leftArm != null)
        {
            addEquipment(_char.leftArm);
        }
        if (_char.rightArm != null)
        {
            addEquipment(_char.rightArm);
        }
        if (_char.leftLeg != null)
        {
            addEquipment(_char.leftLeg);
        }
        if (_char.rightLeg != null)
        {
            addEquipment(_char.rightLeg);
        }
    }

    public bool addItem(GameItem item)
    {
        for (int i = 0; i < itens.Length; i++)
        {
            ItemSlotController slot = itens[i].GetComponent<ItemSlotController>();
            if (!slot.hasItem)
            {
                slot.addToSlot(item);
                return true;
            }
        }
        return false;
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

        ItemSlotController gamItm = itm.GetComponent<ItemSlotController>();
        gamItm.addToSlot(equipment);
    }

    void removeEquipment(EquipmentType type)
    {
        
    }
}
