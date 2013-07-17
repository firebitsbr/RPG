using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{
	public float charSpeed;


	SpriteAnimation scriptAnim;
	bool[] canMove;
	//private Vector3 speed = new Vector3(0, 0, 0);
	GameObject hoverObject;

    private Vector2 _targetPos;
    private GameObject _target;
    private ObjectType _targetType;

	void Start ()
	{
		canMove = new bool[4];
		canMove[0] = canMove[1] = canMove[2] = canMove[3] = true;
		scriptAnim = this.gameObject.GetComponent<SpriteAnimation>();
		rigidbody.detectCollisions = true;

        _targetPos = new Vector2(this.transform.position.x, this.transform.position.y);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

    public void moveTo(float _x, float _y) {

        _targetPos = new Vector2(_x, _y);
        //Debug.Log(_x + "____" + _y);
        //float dist = Vector2.Distance(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(_x, _y));

        //Debug.Log(dist);
    }
	
	void FixedUpdate () {


        if (Input.GetMouseButtonDown(0) && GlobalInput.verifyInput(InputType.GameMap))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit))
            {
                moveTo(hit.transform.position.x, hit.transform.position.y);
                if (hit.collider.gameObject.GetComponent<ItemBase>() != null)
                {
                    //Debug.Log("ITEM");
                    _targetType = ObjectType.Item;
                    _target = hit.collider.gameObject;

                }
                else if (hit.collider.gameObject.GetComponent<TileChanges>() != null) 
                {
                    //Debug.Log("TILE");
                    if (hit.collider.gameObject.GetComponent<ActionTile>() != null)
                    {
                        _targetType = ObjectType.Tile;
                        _target = hit.collider.gameObject;
                    }
                }
                else if (hit.collider.gameObject.GetComponent<GameCharacterController>() != null)
                {
                    //Debug.Log("CHARACTER");
                    _targetType = ObjectType.Character;
                    _target = hit.collider.gameObject;
                }
            }
        }

        if (Mathf.Abs(_targetPos.x - this.transform.position.x) < 1)
        {
            this.rigidbody.velocity = new Vector3(0, this.rigidbody.velocity.y, 0);
        }
        else
        {
            if (_targetPos.x - this.transform.position.x < 0)
            {
                this.rigidbody.velocity = new Vector3(-charSpeed, this.rigidbody.velocity.y, 0);
                scriptAnim.moveLeft();
            }
            else
            {
                this.rigidbody.velocity = new Vector3(charSpeed, this.rigidbody.velocity.y, 0);
                scriptAnim.moveRight();
            }
        }
        if (Mathf.Abs(_targetPos.y - this.transform.position.y) < 1)
        {
            this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, 0, 0);
        }
        else
        {
            if (_targetPos.y - this.transform.position.y < 0)
            {
                this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, -charSpeed, 0);
                scriptAnim.moveDown();
            }
            else
            {
                this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, charSpeed, 0);
                scriptAnim.moveUp();
            }
        }

        if (this.rigidbody.velocity.x == 0 && this.rigidbody.velocity.y == 0)
        {
            scriptAnim.hasAnim = false;
        }
	}

    public void verifyTarget(GameObject obj)
    {
        if (_targetType != ObjectType.Unknown)
        {
            if (obj == _target)
            {
                if (hoverObject != null)
                {
                    if (hoverObject.GetComponent<ActionTile>())
                    {
                        Debug.Log("item");
                        hoverObject.GetComponent<ActionTile>().ClickAction(this.gameObject);
                    }
                    if (hoverObject.GetComponent<ActionCharacter>())
                    {
                        Debug.Log("character");
                        hoverObject.GetComponent<ActionCharacter>().ClickAction();
                    }
                    hoverObject = null;
                }
                else
                {
                    Debug.Log("no action possible");
                }

                _targetPos.x = this.transform.position.x;
                _targetPos.y = this.transform.position.y;
                scriptAnim.hasAnim = false;
                this.rigidbody.velocity = new Vector3(0, 0, 0);
                _targetType = ObjectType.Unknown;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        verifyTarget(col.gameObject);
    }
    void OnTriggerEnter(Collider col)
    {
        verifyTarget(col.gameObject);
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

