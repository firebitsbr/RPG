using UnityEngine;
using System.Collections;

public class ActionCharacter : MonoBehaviour {

    public ActionTileType _actionType = ActionTileType.ChangeSprite;
    
	void Start () {
	
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

                this.gameObject.GetComponent<TileChanges>().updateCollision();

                break;
            case ActionTileType.PickupItem:

                Destroy(this.gameObject);

                break;
        }


    }
    public void HoverAction()
    {

    }
}
