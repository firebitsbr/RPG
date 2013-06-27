using UnityEngine;
using System.Collections;

public class ButtonRemoveEquipped : MonoBehaviour {

	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GameObject itm = GameObject.Find("/WindowCharacter/BoxItemDetail").GetComponent<CharItemDetailController>().selectedItem;
        if (itm != null)
        {
            ItemSlotController slot = itm.GetComponent("ItemSlotController") as ItemSlotController;
            GameObject.Find("/WindowItem/BoxListItens").GetComponent<ListItensController>().addItem(slot.item);
            slot.removeItem();

            CharItemDetailController det = GameObject.Find("/WindowCharacter/BoxItemDetail").GetComponent<CharItemDetailController>();
            det.hideAll();
        }
    }
}
