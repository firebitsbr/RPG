using UnityEngine;
using System.Collections;


public struct NpcTalk
{
    public float speed;
    public string text;
    public ActionTextType onDone;
};
public struct NpcPlayAnimation
{
    public int[] animation;
    public float speed;
};
public struct NPCWalkAndTalk
{
    public NpcWalkTo walkTo;
    public NpcTalk talk;
};
public struct NpcFollow
{
    public GameObject target;
    public float speed;
};
public struct NpcWalkTo
{
    public Vector3 destin;
    public ActionTextType onDonw;
};
public struct NpcWalkTalkFollow
{
    public NpcWalkTo walk;
    public NpcTalk talk;
    public NpcFollow follow;
};
public struct SpriteAnim
{
    public string name;
    public int[] data;
    public float speed;
};
/*********************************************************************************************************************/