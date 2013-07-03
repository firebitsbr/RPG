using UnityEngine;
using System.Collections;

public class GameCharacter {


    private GameItem _leftLeg;
    private GameItem _rightLeg;
    private GameItem _leftArm;
    private GameItem _rightArm;
    private GameAttributes _attributes;
    private GameItem[] _itens = new GameItem[4];

    private GameSkill[] _attacks = new GameSkill[4];
    private GameSkill[] _specials = new GameSkill[4];

    private bool _ready;
    private float _timer;

    private string _name;

	// Use this for initialization
	void Start () {
        _timer = 0;


	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RemoveEquippedEquipment(EquipmentType pos)
    {
        switch (pos)
        {

            case EquipmentType.LeftArm:

                GlobalItens.AddToInventory(_leftArm);
                _leftArm = null;

                break;
            case EquipmentType.RightArm:

                GlobalItens.AddToInventory(_rightArm);
                _rightArm = null;

                break;
            case EquipmentType.LeftLeg:

                GlobalItens.AddToInventory(_leftLeg);
                _leftLeg = null;

                break;
            case EquipmentType.RightLeg:
                
                GlobalItens.AddToInventory(_rightLeg);
                _rightLeg = null;

                break;
        }
    }

    public void RemoveEquippedItem(GameItem itm)
    {
        for (int i = 0; i < 4; i++)
        {
            if (_itens[i] != null && _itens[i] == itm)
            {
                GlobalItens.AddToInventory(_itens[i]);
                _itens[i] = null;
            }
        }
    }

    public void RestartTimer()
    {
        _ready = false;
        _timer = 0;
    }

    public bool UpdateTimer()
    {
        if (_ready)
        {
            return true;
        }

        _timer += Time.deltaTime;
        if (_timer > _attributes.time)
        {
            _timer = _attributes.time;
            _ready = true;
            return true;
        }

        return false;
    }



    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    public bool ready
    {
        get { return _ready; }
        set { _ready = value; }
    }
    public float timer
    {
        get { return _timer; }
        set { _timer = value; }
    }
    public GameSkill[] attacks
    {
        get { return _attacks; }
        set { _attacks = value; }
    }
    public GameSkill[] specials
    {
        get { return _specials; }
        set { _specials = value; }
    }
    public GameItem[] itens
    {
        get { return _itens; }
        set { _itens = value; }
    }
    public GameAttributes attributes
    {
        get { return _attributes; }
        set { _attributes = value; }
    }
    public GameItem leftLeg
    {
        get { return _leftLeg; }
        set { _leftLeg = value; }
    }
    public GameItem rightLeg
    {
        get { return _rightLeg; }
        set { _rightLeg = value; }
    }
    public GameItem leftArm
    {
        get { return _leftArm; }
        set { _leftArm = value; }
    }
    public GameItem rightArm
    {
        get { return _rightArm; }
        set { _rightArm = value; }
    }
    /**********************************************************************************************/
}
