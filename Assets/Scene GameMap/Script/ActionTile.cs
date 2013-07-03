using UnityEngine;
using System.Collections;



public class ActionTile: MonoBehaviour
{

    public int spritePressed;
    public ActionTileType _actionType = ActionTileType.ChangeSprite;

    private int oldSprite;

    // Use this for initialization
    void Start()
    {
        oldSprite = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.GetComponent<CharacterMovement>() != null)
        {
            other.gameObject.GetComponent<CharacterMovement>().setHoverObj(this.gameObject);
        }
    }

    void OnCollisionExit(Collision other)
    {

        if (other.gameObject.GetComponent<CharacterMovement>() != null)
        {
            other.gameObject.GetComponent<CharacterMovement>().removeHoverObj(this.gameObject);
        }
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


    public void ClickAction()
    {
        switch (_actionType)
        {
            case ActionTileType.ChangeSprite:

                if (oldSprite == 0)
                {
                    oldSprite = this.gameObject.GetComponent<TileChanges>().TileNumber;
                    this.gameObject.GetComponent<TileChanges>().changeTile(spritePressed);
                }
                else
                {
                    this.gameObject.GetComponent<TileChanges>().changeTile(oldSprite);
                    oldSprite = 0;
                }
                this.gameObject.GetComponent<TileChanges>().updateCollision();

                break;
            case ActionTileType.PickupItem:

                GlobalItens.AddToInventory(this.GetComponent<ItemBase>().item);
                Destroy(this.gameObject);

                break;
        }
    }
    public void HoverAction()
    { 

    }
}

