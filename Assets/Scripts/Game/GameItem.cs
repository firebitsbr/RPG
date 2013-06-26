using UnityEngine;
using System.Collections;

public class GameItem : MonoBehaviour {

	// Use this for initialization

    private ItemType _type;
    private EquipmentType _equipmentType;
    private AlchemyType _alchemyType;

    private string _description;
    private int _price;
    private int _sprite;

    private GameSkill _attack;
    private GameSkill _special;

    private int _damage;
    private TargetTypes _target;
    private TargetAttribute _attribute;

	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public ItemType type
    {
        get { return _type; }
        set { _type = value; }
    }
    public EquipmentType equipmentType
    {
        get { return _equipmentType; }
        set { _equipmentType = value; }
    }
    public AlchemyType alchemyType
    {
        get { return _alchemyType; }
        set { _alchemyType = value; }
    }
    public TargetTypes target
    {
        get { return _target; }
        set { _target = value; }
    }
    public int damage
    {
        get { return _damage; }
        set { _damage = value; }
    }
    public TargetAttribute attribute
    {
        get { return _attribute; }
        set { _attribute = value; }
    }


    public GameSkill attack
    {
        get { return _attack; }
        set { _attack = value; }
    }
    public GameSkill special
    {
        get { return _special; }
        set { _special = value; }
    }
    public string description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int price
    {
        get { return _price; }
        set { _price = value; }
    }
    public int sprite
    {
        get { return _sprite; }
        set { _sprite = value; }
    }
}