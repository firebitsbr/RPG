using UnityEngine;
using System.Collections;

public class WindowCharacterController : MonoBehaviour {


    public GameObject _boxCharChanger;
    public GameObject _boxCharDetail;
    public GameObject _boxEquipped;
    public GameObject _boxItemDetail;
    public GameObject _boxItemList;


    public GameObject _buttonCharDelete;
    public GameObject _buttonCharOpenInv;

    public GameObject _buttonCharBack;
    public GameObject _buttonCharEquip;

    private GameObject _slotSelected;
    private GameItem _currentItemSelected;

    private int _currentCharacterSelected;
    private ItemType _itemSelected;
    private EquipmentType _equipmentSelected;
    private int _itemNumSelected;

    private bool _started = false;

	void Start () {

        LoadCharDetail(0);
        _started = true;
	}

    void OnEnable()
    {
        if (_started)
        {
            LoadCharDetail(0);
        }
    }

    public void OpenChangeItem(bool value)
    {
        _buttonCharDelete.SetActive(!value);
        _buttonCharOpenInv.SetActive(!value);
        _buttonCharBack.SetActive(value);
        _buttonCharEquip.SetActive(value);
    }


    public void LoadCharDetail(int charNum)
    {
        _boxItemList.SetActive(false);
        _boxEquipped.SetActive(true);
        OpenChangeItem(false);
        slotSelected = null;

        _currentCharacterSelected = charNum;
        GameCharacter curr = GlobalCharacter.party[_currentCharacterSelected];
        _boxCharChanger.GetComponent<BoxChangeCharacter>()._charName.guiText.text = curr.name;

        _boxCharDetail.GetComponent<CharDetailController>().UpdateCharDetail(curr);
        _boxEquipped.GetComponent<CharEquippedController>().UpdateCharDetail(curr);
    }

    public void HideListToEquip()
    {
        _boxEquipped.SetActive(true);
        _boxItemList.SetActive(false);
    }

    public void ShowListToEquip()
    {
        _boxEquipped.SetActive(false);
        _boxItemList.SetActive(true);
        
        switch (_itemSelected)
        {
            case ItemType.Alchemy:
                _boxItemList.GetComponent<ListItensController>().ShowItens();
                break;
            case ItemType.Equipment:
                _boxItemList.GetComponent<ListItensController>().ShowEquipment(_equipmentSelected);
                break;
        }
    }

    public void UpdateFromGlobal()
    {

        GameCharacter curr = GlobalCharacter.party[_currentCharacterSelected];
        _boxCharChanger.GetComponent<BoxChangeCharacter>()._charName.guiText.text = curr.name;

        _boxCharDetail.GetComponent<CharDetailController>().UpdateCharDetail(curr);
        _boxEquipped.GetComponent<CharEquippedController>().UpdateCharDetail(curr);

    }


    public int itemNumSelected
    {
        get { return _itemNumSelected; }
        set { _itemNumSelected = value; }
    }

    public EquipmentType equipmentSelected
    {
        get { return _equipmentSelected; }
        set { _equipmentSelected = value; }
    }

    public ItemType itemSelected
    {
        get { return _itemSelected; }
        set { _itemSelected = value; }
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

    public GameObject slotSelected
    {
        get { return _slotSelected; }
        set {
            if (_slotSelected != null)
            {
                _slotSelected.guiTexture.color = Color.grey;
            }
            _slotSelected = value;
            if (_slotSelected != null) {
                _slotSelected.guiTexture.color = new Color(0.2f,0.2f,0.2f,0.5f);
            }
        }
    }
    
}
