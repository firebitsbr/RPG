using UnityEngine;
using System.Collections;

public class ButtonActionController : MonoBehaviour {


    public GameObject _characterSlot;
    public GameObject _boxAction;

    private GameObject _charSelected;
    
	void Start () {

        for (int i = 0; i < this.transform.GetChildCount(); i++)
        {
            ButtonAction but = this.transform.GetChild(i).GetComponent("ButtonAction") as ButtonAction;
            if (but)
            {
                but.boxAction = _boxAction;
            }
        }

        _boxAction.SetActive(false);
	}

    public void updateButtons()
    {
        for (int i = 0; i < this.transform.GetChildCount(); i++)
        {
            ButtonAction but = this.transform.GetChild(i).GetComponent("ButtonAction") as ButtonAction;
            if (but)
            {
                but.SetSelected(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
	
	}
}
