using UnityEngine;
using System.Collections;

public class HudController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetDetails(string type, int cost)
    {
        //Debug.Log(GameObject.Find("LocalText"));
        (GameObject.Find("/Hud/LocalText").GetComponent("GUIText") as GUIText).text = type;
        (GameObject.Find("/Hud/PriceText").GetComponent("GUIText") as GUIText).text = cost.ToString() + "gp";
    }
}