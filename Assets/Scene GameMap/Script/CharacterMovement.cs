using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{
	public float charSpeed;


	SpriteAnimation scriptAnim;
	bool[] canMove;
	//private Vector3 speed = new Vector3(0, 0, 0);
	GameObject hoverObject;
	// Use this for initialization
	void Start ()
	{
		canMove = new bool[4];
		canMove[0] = canMove[1] = canMove[2] = canMove[3] = true;
		scriptAnim = this.gameObject.GetComponent<SpriteAnimation>();
		rigidbody.detectCollisions = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown("space")) {

            if (hoverObject != null)
            {
                if (hoverObject.GetComponent<ActionTile>())
                {
                    hoverObject.GetComponent<ActionTile>().ClickAction(this.gameObject);
                }
                if (hoverObject.GetComponent<ActionCharacter>())
                {
                    hoverObject.GetComponent<ActionCharacter>().ClickAction();
                }


			} else {
				Debug.Log("no action possible");
			}
		}
	}
	
	void FixedUpdate () {


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("action button");
        }
	
		if(Input.GetKey("left")) {
			scriptAnim.moveLeft();
            this.rigidbody.velocity = new Vector3(-charSpeed, this.rigidbody.velocity.y, 0);
			
		}
		if(Input.GetKey("right")) {
			scriptAnim.moveRight();
			this.rigidbody.velocity = new Vector3(charSpeed, this.rigidbody.velocity.y, 0);
		}
		if(Input.GetKey("up")) {
			scriptAnim.moveUp();
            this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, charSpeed, 0);
			
		}
		if(Input.GetKey("down")) {
			scriptAnim.moveDown();
            this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, -charSpeed, 0);
		}
		
		if(!Input.GetKey("up") && !Input.GetKey("down")) {
            this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, 0, 0);
		}
		if(!Input.GetKey("right") && !Input.GetKey("left")) {
            this.rigidbody.velocity = new Vector3(0, this.rigidbody.velocity.y, 0);
		}
		if(!Input.GetKey("up") && !Input.GetKey("down") && !Input.GetKey("right") && !Input.GetKey("left")) {
			scriptAnim.hasAnim = false;
		}
	}
	
	
	public void setHoverObj(GameObject obj) {
        hoverObject = obj;
	}
    public void removeHoverObj(GameObject obj)
    {
        if (hoverObject == obj)
        {
            hoverObject = null;
		}
	}
}

