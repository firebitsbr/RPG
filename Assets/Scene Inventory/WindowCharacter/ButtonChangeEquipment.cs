using UnityEngine;
using System.Collections;

public class ButtonChangeEquipment : MonoBehaviour {

    public GameObject _charController;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {

        _charController.GetComponent<WindowCharacterController>().ShowListToEquip();
        _charController.GetComponent<WindowCharacterController>().OpenChangeItem(true);

    }
}
