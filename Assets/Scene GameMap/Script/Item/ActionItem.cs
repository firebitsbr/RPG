using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ActionItem : MonoBehaviour
{
    public const int ACTION_CHANGE_SPRITE = 1;
    public const int ACTION_PICKUP_ITEM = 2;

    public float spritePressed;
    public int ActionType = 1;

    public string actionName;
    

    //private float oldSprite;

    void Start()
    {
        //oldSprite = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterMovement>() != null)
        {
            other.GetComponent<CharacterMovement>().setHoverObj(this.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.GetComponent<CharacterMovement>() != null)
        {
            other.GetComponent<CharacterMovement>().removeHoverObj(this.gameObject);
        }
    }

}