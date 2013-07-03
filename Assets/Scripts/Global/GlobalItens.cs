using UnityEngine;
using System.Collections;

public class GlobalItens : MonoBehaviour {

    private static ArrayList _itens;
    private static ArrayList _inventory;
	
	public static void Init() {

        _inventory = new ArrayList();
        _inventory.Add(generateAlchemy(AlchemyType.HealLife));
        _inventory.Add(generateAlchemy(AlchemyType.HealLife));
        _inventory.Add(generateAlchemy(AlchemyType.HealLife));
        _inventory.Add(generateAlchemy(AlchemyType.HealLife));

        _inventory.Add(generateEquipment(EquipmentType.LeftArm));
        _inventory.Add(generateEquipment(EquipmentType.LeftArm));
        _inventory.Add(generateEquipment(EquipmentType.LeftArm));


	}

    public static void AddToInventory(GameItem itm)
    {
        _inventory.Add(itm);
    }
    public static void RemoveFromInventory(GameItem itm)
    {
        _inventory.Remove(itm);
    }
	
    public static GameItem generateAlchemy(AlchemyType type) {

        GameItem _itm = new GameItem();
        _itm.type = ItemType.Alchemy;
        _itm.alchemyType = type;
        _itm.setAttributes("alchemy", "description", 6, 100);
        _itm.setAlchemyAttributes(20, TargetTypes.Self, TargetAttribute.Life);

        return _itm;
    }


    public static GameItem generateEquipment(EquipmentType equip)
    {
        GameItem _itm = new GameItem();
        _itm.type = ItemType.Equipment;
        _itm.equipmentType = equip;
        _itm.setAttributes("equipment", "description", 2, 100);

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
