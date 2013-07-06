using UnityEngine;
using System.Collections;

public class GlobalItens : MonoBehaviour {

    private static ArrayList _itens;
    private static ArrayList _inventory;
    private static bool _hasInit = false;
	
	public static void Init() {

        if (!_hasInit)
        {
            _inventory = new ArrayList();
            _inventory.Add(generateAlchemy(AlchemyType.HealLife));
            _inventory.Add(generateAlchemy(AlchemyType.HealLife));
            _inventory.Add(generateAlchemy(AlchemyType.HealLife));
            _inventory.Add(generateAlchemy(AlchemyType.HealLife));

            _inventory.Add(generateEquipment(EquipmentType.LeftArm));
            _inventory.Add(generateEquipment(EquipmentType.LeftArm));
            _inventory.Add(generateEquipment(EquipmentType.LeftArm));

            _hasInit = true;
        }
	}

    public static void AddToInventory(GameItem itm)
    {
        _inventory.Add(itm);
        Debug.Log(_inventory.Count);
    }
    public static void RemoveFromInventory(GameItem itm)
    {
        _inventory.Remove(itm);
    }
	
    public static GameItem generateAlchemy(AlchemyType type) {

        GameItem _itm = new GameItem();
        _itm.type = ItemType.Alchemy;
        _itm.alchemyType = type;
        _itm.setAttributes("alchemy", "description", 7, 100);
        _itm.setAlchemyAttributes(20, TargetTypes.Self, TargetAttribute.Life);

        return _itm;
    }

    public static bool isInInventory(GameItem itm)
    {
        return (_inventory.IndexOf(itm) >= 0);
    }


    public static GameItem generateEquipment(EquipmentType equip)
    {
        GameItem _itm = new GameItem();
        _itm.type = ItemType.Equipment;
        _itm.equipmentType = equip;
        _itm.setAttributes("equipment", "description", 9, 100);
        _itm.attributes.SetAttributes(4, 4, 4, 4, 4, 44, 44, 0, 0);

        _itm.attack = new GameSkill();
        _itm.attack.SetAttributes("attack skill", "description", 10, TargetTypes.Enemy, TargetAttribute.Life);

        _itm.special = new GameSkill();
        _itm.special.SetAttributes("special skill", "description", 15, TargetTypes.Enemy, TargetAttribute.Life);

        return _itm;
    }


    public static ArrayList inventory
    {
        get { return _inventory; }
        set { _inventory = value; }
    }

    public static ArrayList itens
    {
        get { return _itens; }
        set { _itens = value; }
    }
}
