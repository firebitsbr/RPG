using UnityEngine;
using System.Collections;

public class ButtonDeleteItem : MonoBehaviour {


    // @TODO: nothing

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnMouseDown()
    {
        Debug.Log("DELETE");

        ItemDetailController itm = GameObject.Find("/WindowItem/BoxItemDetail").GetComponent("ItemDetailController") as ItemDetailController;

        (itm.selectedItem.GetComponent("ItemSlotController") as ItemSlotController)._hasItem = false;
        (GameObject.Find("/WindowItem/BoxItemDetail").GetComponent("ItemDetailController") as ItemDetailController).hideAll();
    }
}
