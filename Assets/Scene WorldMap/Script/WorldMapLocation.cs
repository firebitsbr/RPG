using UnityEngine;
using System.Collections;

public class WorldMapLocation : MonoBehaviour
{

    public bool _open;
    public int _cost;
    private string _name;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnMouseDown()
    {
        HudController _hud = GameObject.Find("Hud").GetComponent("HudController") as HudController;
        _hud.SetDetails("Local Name", 3000);
    }
}