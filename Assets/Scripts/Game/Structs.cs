using UnityEngine;
using System.Collections;


public enum ActionTileType
{
    ChangeSprite, PickupItem, GotoLocation, Attack, ChangeOtherSprite, Bless, ShowMessage, TalkToNpc
};
public enum ActionCharacterType
{
    Npc, Monster, Talk
};
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
public enum ItemList
{
    Skull = 0, Ring=1, FullChest = 2, EmptyChest = 3, Cristal = 4, Key = 5, Potion = 6, GreyPotion = 7,BigPotion = 8,LeftHand = 9,RightHand = 10,LeftLeg = 11,RightLeg = 12
};


public enum TextOptionType
{
    NextText, FinishQuest, ReceiveItem, ReceiveDamage, ReceiveBonus, CloseText
};