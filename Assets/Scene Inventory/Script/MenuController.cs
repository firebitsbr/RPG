using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

    // @TODO: nothing

	void Start () {
        for (int i = 0; i < this.transform.GetChildCount(); i++)
        {
            ButtonInventory but = this.transform.GetChild(i).GetComponent<ButtonInventory>();
            if (but._window != null)
            {
                but._window.SetActive(false);
            }
        }
	}
	
	void Update () {
	
	}

    public void updateButtons()
    {
        for (int i = 0; i < this.transform.GetChildCount(); i++)
        {
            ButtonInventory but = this.transform.GetChild(i).GetComponent<ButtonInventory>();
            if (but)
            {
                but.SetSelected(false);
                if (but._window)
                {
                    but._window.SetActive(false);
                }
            }
        }
    }
}