using UnityEngine;
using System.Collections;


public struct NpcTalk
{
    float speed;
    string text;
    NpcAction onDone;
};
public struct NpcPlayAnimation
{
    int[] animation;
    float speed;
};
public struct NPCWalkAndTalk
{
    NpcWalkTo walkTo;
    NpcTalk talk;
};
public struct NpcFollow
{
    GameObject target;
    float speed;
};
public struct NpcWalkTo
{
    Vector3 destin;
    NpcAction onDonw;
};
public struct NpcWalkTalkFollow
{
    NpcWalkTo walk;
    NpcTalk talk;
    NpcFollow follow;
};
/*********************************************************************************************************************/