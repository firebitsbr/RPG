using UnityEngine;
using System.Collections;



public class ActionTile: MonoBehaviour
{

    private object _actionValue;
    private bool _spriteCollision;
    public ActionTileType _actionType;

    private int oldSprite;
    public string tooltip;

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
        if (tooltip != null)
        {
            Camera.main.GetComponent<GameController>().ShowTooltip(this.tooltip);
        }
    }

    void OnCollisionExit(Collision other)
    {

        if (other.gameObject.GetComponent<CharacterMovement>() != null)
        {
            other.gameObject.GetComponent<CharacterMovement>().removeHoverObj(this.gameObject);
        }
        if (tooltip != null)
        {
            Camera.main.GetComponent<GameController>().ShowTooltip("");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterMovement>() != null)
        {
            other.GetComponent<CharacterMovement>().setHoverObj(this.gameObject);
        }
        if (tooltip != null)
        {
            Camera.main.GetComponent<GameController>().ShowTooltip(this.tooltip);
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.GetComponent<CharacterMovement>() != null)
        {
            other.GetComponent<CharacterMovement>().removeHoverObj(this.gameObject);
        }
        if (tooltip != null)
        {
            Camera.main.GetComponent<GameController>().ShowTooltip("");
        }
    }


    public void ClickAction(GameObject other = null)
    {
        switch (_actionType)
        {
            case ActionTileType.ChangeSpriteToNotCollide:
            case ActionTileType.ChangeSpriteToCollide:

                if (oldSprite == 0)
                {
                    oldSprite = this.gameObject.GetComponent<TileChanges>().TileNumber;
                    this.gameObject.GetComponent<TileChanges>().changeTile((int)(actionValue));
                }
                else
                {
                    this.gameObject.GetComponent<TileChanges>().changeTile(oldSprite);
                    oldSprite = 0;
                }
                this.gameObject.GetComponent<TileChanges>().updateCollision(_spriteCollision);

                break;
            case ActionTileType.PickupItem:

                GlobalItens.AddToInventory(this.GetComponent<ItemBase>().item);
                Destroy(this.gameObject);

                break;
            case ActionTileType.GotoLocation:

                int[] val = (int[])(actionValue);
                Debug.Log("gotolocation");
                other.transform.position = new Vector3(16 * val[0], 16 * val[1], other.transform.position.z);

                break;
        }
    }
    public void HoverAction()
    { 

    }


    public object actionValue
    {
        get { return _actionValue; }
        set { _actionValue = value; }
    }
    public bool spriteCollision
    {
        get { return _spriteCollision; }
        set { _spriteCollision = value; }
    }
}

