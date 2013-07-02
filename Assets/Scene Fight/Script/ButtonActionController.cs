using UnityEngine;
using System.Collections;

public class ButtonActionController : MonoBehaviour {


    public GameObject _boxAction;

    public GameObject _character1;
    public GameObject _character2;
    public GameObject _character3;

    public GameObject _buttonAction;
    public GameObject _buttonSpecial;
    public GameObject _buttonItem;

    private bool _buttonActive;
    
	void Start () {


        _buttonAction.GetComponent<ButtonAction>().boxAction = _boxAction;
        _buttonSpecial.GetComponent<ButtonAction>().boxAction = _boxAction;
        _buttonItem.GetComponent<ButtonAction>().boxAction = _boxAction;
        
        
        _boxAction.SetActive(false);

        hideButtons();
	}


    public void hideButtons()
    {
        updateButtons();
        _buttonAction.SetActive(false);
        _buttonSpecial.SetActive(false);
        _buttonItem.SetActive(false);
        
        _buttonActive = false;
    }

    public void showButtons()
    {
        _buttonAction.SetActive(true);
        _buttonSpecial.SetActive(true);
        _buttonItem.SetActive(true);

        _buttonActive = true;
    }

    public void updateButtons()
    {
        _buttonAction.GetComponent<ButtonAction>().SetSelected(false);
        _buttonSpecial.GetComponent<ButtonAction>().SetSelected(false);
        _buttonItem.GetComponent<ButtonAction>().SetSelected(false);
    }


    public bool buttonActive
    {
        get { return _buttonActive; }
        set { _buttonActive = value; }
    }
}
