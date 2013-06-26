using UnityEngine;
using System.Collections;

public class CharEquippedController : MonoBehaviour {

    public GameObject _LeftLeg;
    public GameObject _RightLeg;

    public GameObject _LeftArm;
    public GameObject _RightArm;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addEquipment(GameItem equipment)
    {
        switch (equipment.equipmentType)
        {
            case EquipmentType.LeftArm:
                removeEquipment("LeftArm");
                break;
            case EquipmentType.LeftLeg:
                removeEquipment("LeftLeg");
                break;
            case EquipmentType.RightArm:
                removeEquipment("RightArm");
                break;
            case EquipmentType.RightLeg:
                removeEquipment("RightLeg");
                break;
        }
    }
    void removeEquipment(string local)
    {
        ItemSlotController itm = GameObject.Find("/WindowCharacter/BoxCharEquipped/" + local).GetComponent("ItemSlotController") as ItemSlotController;


        if (itm._hasItem)
        {

        }
        else
        {

        }
    }
}
