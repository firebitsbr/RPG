using UnityEngine;
using System.Collections;

public class ButtonActionController : MonoBehaviour {


    public GameObject _characterSlot;
    public GameObject _boxAction;

    private GameObject _charSelected;
    private ArrayList _listActions;
    
	void Start () {

        _listActions = new ArrayList();

        for (int i = 0; i < this.transform.GetChildCount(); i++)
        {
            ButtonAction but = this.transform.GetChild(i).GetComponent("ButtonAction") as ButtonAction;
            if (but)
            {
                _listActions.Add(this.transform.GetChild(i).gameObject);
                but.boxAction = _boxAction;
            }
        }

        _boxAction.SetActive(false);

        hideButtons();
	}

    public void hideButtons()
    {
        for (int i = 0; i < _listActions.Count; i++)
        {
            (_listActions[i] as GameObject).SetActive(false);
        }
    }
    public void showButtons()
    {
        for (int i = 0; i < _listActions.Count; i++)
        {
            (_listActions[i] as GameObject).SetActive(true);
        }
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
