using UnityEngine;
using System.Collections;

public class ButonUseItem : MonoBehaviour {

    // @TODO: verify if is item or equipment. add item to equipped

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        Debug.Log("USE ITEM");


        // ItemDetailController idc = GameObject.Find("/WindowItem/BoxItemDetail").GetComponent("ItemDetailController") as ItemDetailController;

        // GameItem itm = (idc.selectedItem.GetComponent("ItemSlotController") as ItemSlotController).item;
    }
}
