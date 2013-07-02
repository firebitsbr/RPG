using UnityEngine;
using System.Collections;

public enum TargetTypes
{
    Self, Enemy, Party, AllEnemies, All, OtherParty
};
public enum TargetAttribute
{
    Strength, Agility, Endurance, Life, Money, Technology, Time, Alchemy
};
public enum ItemType
{
    Alchemy, Equipment
};
public enum EquipmentType
{
    Arm, LeftArm, RightArm, Leg, LeftLeg, RightLeg
};
public enum AlchemyType
{
    HealLife, IncreaseDamage, IncreaseSpeed
};
public enum OptionType
{
    Attack, Special, Item
};
public enum ActionType
{
    GameSkill, GameItem
};