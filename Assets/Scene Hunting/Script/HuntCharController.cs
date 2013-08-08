using UnityEngine;
using System.Collections;

public class HuntCharController : MonoBehaviour {


    public float charSpeed;

	void Start () {
	
	}
	
	

	void Update () {

        if (Input.GetKey("left"))
        {
            this.rigidbody.velocity = new Vector3(-charSpeed, 0, 0);
        }
        else if (Input.GetKey("right"))
        {
            this.rigidbody.velocity = new Vector3(charSpeed, 0, 0);
        }
        else
        {
            this.rigidbody.velocity = new Vector3(0, 0, 0);
        }

	}
}
