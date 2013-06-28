using UnityEngine;
using System.Collections;

public class ButonUseItem : MonoBehaviour {

    // @TODO: verify if is item or equipment. add item to equipped
    public GameObject _boxItem;
    public GameObject _boxItemDetail;
    public GameObject _boxEquipment;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        Debug.Log("USE ITEM");

        ItemDetailController idc = _boxItemDetail.GetComponent<ItemDetailController>();

        ItemSlotController itm = idc.selectedItem.GetComponent<ItemSlotController>();

        switch (itm.item.type)
        {
            case ItemType.Alchemy:

                _boxItem.GetComponent<CharItemEquippedController>().addItem(itm.item);
                
                break;
            case ItemType.Equipment:

                _boxEquipment.GetComponent<CharEquippedController>().addEquipment(itm.item);
                
                break;
        }

        _boxItemDetail.GetComponent<ItemDetailController>().hideAll();
        itm.removeItem();

    }
}
