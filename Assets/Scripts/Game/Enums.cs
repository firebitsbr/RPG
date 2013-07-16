using UnityEngine;
using System.Collections;


public enum ActionTileType
{
    Unknown, ChangeSpriteToCollide, ChangeSpriteToNotCollide, ChangeOtherSpriteToCollide, ChangeOtherSpriteToNotCollide,
    PickupItem, GotoLocation, Attack, Bless, ShowMessage, TalkToNpc, Battle
};
public enum ActionCharacterType
{
    Unknown, Npc, Monster, Talk
};
public enum TargetTypes
{
    Unknown, Self, Enemy, Party, AllEnemies, All, OtherParty
};
public enum TargetAttribute
{
    Unknown, Strength, Agility, Endurance, Life, Money, Technology, Time, Alchemy
};
public enum ItemType
{
    Unknown, Alchemy, Equipment
};
public enum EquipmentType
{
    Unknown, Arm, LeftArm, RightArm, Leg, LeftLeg, RightLeg
};
public enum AlchemyType
{
    Unknown, HealLife, IncreaseDamage, IncreaseSpeed
};
public enum OptionType
{
    Unknown, Attack, Special, Item, Defense
};
public enum ItemList
{
    Skull = 0, Ring = 1, FullChest = 2, EmptyChest = 3, Cristal = 4, Key = 5, Potion = 6, GreyPotion = 7, BigPotion = 8, LeftHand = 9, RightHand = 10, LeftLeg = 11, RightLeg = 12
};

public enum ActionTextType
{
    Unknown, NextText, FinishQuest, ReceiveItem, ReceiveDamage, ReceiveBonus, CloseText, ShowText, ShowStore, ShowOptions, Battle,
    WalkTo, Talk, TurnLeft, TurnRight, TurnDown, TurnUp, PlayAnimation, WalkAndTalk, WalkTalkFollow, Follow
};
public enum InputType
{
    Unknown, WorldMap
};