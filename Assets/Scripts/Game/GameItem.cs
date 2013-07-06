using UnityEngine;
using System.Collections;

public class GameItem {

	// Use this for initialization

    private ItemType _type;
    private EquipmentType _equipmentType;
    private AlchemyType _alchemyType;

    private string _name;
    private string _description;
    private int _price;
    private int _sprite;

    private GameSkill _attack;
    private GameSkill _special;

    private int _damage;
    private TargetTypes _target;
    private TargetAttribute _attribute;

    private GameAttributes _attributes;
    private Color _color;

    public void setAttributes(string _nam, string _des, int _spr, int _pri)
    {
        _attributes = new GameAttributes();
        _name = _nam;
        _description = _des;
        _sprite = _spr;
        _price = _pri;
        
        _color = new Color(Random.Range(0, 10) * 0.1f, Random.Range(0, 10) * 0.1f, Random.Range(0, 10) * 0.1f);
    }

    public void setAlchemyAttributes(int _dam, TargetTypes _tar, TargetAttribute _atr)
    {
        _damage = _dam;
        _target = _tar;
        _attribute = _atr;
    }



    public Color color
    {
        get { return _color; }
        set { _color = value; }
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

    public GameAttributes attributes
    {
        get { return _attributes; }
        set { _attributes = value; }
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
    public string name
    {
        get { return _name; }
        set { _name = value; }
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