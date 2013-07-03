using UnityEngine;
using System.Collections;

public class WindowCharacterController : MonoBehaviour {


    public GameObject _boxCharChanger;
    public GameObject _boxCharDetail;
    public GameObject _boxEquipped;
    public GameObject _boxItemDetail;
    public GameObject _boxItemList;

    private GameItem _currentItemSelected;

    private int _currentCharacterSelected;

	void Start () {


        LoadCharDetail(0);
	}
    public void LoadCharDetail(int charNum)
    {
        _currentCharacterSelected = charNum;
        GameCharacter curr = GlobalCharacter.party[_currentCharacterSelected];
        _boxCharChanger.GetComponent<BoxChangeCharacter>()._charName.guiText.text = curr.name;

        _boxCharDetail.GetComponent<CharDetailController>().UpdateCharDetail(curr);
        _boxEquipped.GetComponent<CharEquippedController>().UpdateCharDetail(curr);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void UpdateFromGlobal()
    {

        GameCharacter curr = GlobalCharacter.party[_currentCharacterSelected];
        _boxCharChanger.GetComponent<BoxChangeCharacter>()._charName.guiText.text = curr.name;

        _boxCharDetail.GetComponent<CharDetailController>().UpdateCharDetail(curr);
        _boxEquipped.GetComponent<CharEquippedController>().UpdateCharDetail(curr);

    }


    public int currentCharacterSelected
    {
        get { return _currentCharacterSelected; }
        set { _currentCharacterSelected = value; }
    }

    public GameItem currentItemSelected
    {
        get { return _currentItemSelected; }
        set { _currentItemSelected = value; }
    }
}
