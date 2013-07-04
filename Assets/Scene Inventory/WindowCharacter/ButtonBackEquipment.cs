using UnityEngine;
using System.Collections;

public class ButtonBackEquipment : MonoBehaviour {

    public GameObject _charController;

	void Start () {
	
	}
	

    void OnMouseDown()
    {
        _charController.GetComponent<WindowCharacterController>().HideListToEquip();
        _charController.GetComponent<WindowCharacterController>().OpenChangeItem(false);
    }
}
