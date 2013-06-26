using UnityEngine;
using System.Collections;

public class ButtonDeleteItem : MonoBehaviour {

	// Use this for initialization
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
