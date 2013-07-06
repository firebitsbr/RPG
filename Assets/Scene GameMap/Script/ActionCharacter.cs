using UnityEngine;
using System.Collections;

public class ActionCharacter : MonoBehaviour {

    public ActionTextType _actionType = ActionTextType.CloseText;
    
	void Start () {
	
	}

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.GetComponent<CharacterMovement>() != null)
        {
            other.gameObject.GetComponent<CharacterMovement>().setHoverObj(this.gameObject);
        }

        Camera.main.GetComponent<GameController>().ShowTooltip(this.GetComponent<GameCharacterController>().character.name);
    }

    void OnCollisionExit(Collision other)
    {

        if (other.gameObject.GetComponent<CharacterMovement>() != null)
        {
            other.gameObject.GetComponent<CharacterMovement>().removeHoverObj(this.gameObject);
        }

        Camera.main.GetComponent<GameController>().ShowTooltip("");
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
        Debug.Log("action npc");
        switch (_actionType)
        {
            case ActionTextType.ShowText:

                Camera.main.GetComponent<GameController>().ShowChat();

                break;
            default:


                break;
        }


    }
    public void HoverAction()
    {

    }
}
