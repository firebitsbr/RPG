using UnityEngine;
using System.Collections;

public class ChatOption : MonoBehaviour {

    private ActionTextType _actionFinish;

	void Start () {
	
	}
	
	void Update () {
	
	}
    void OnMouseDown()
    {
        Debug.Log("option click");

        this.transform.parent.GetComponent<ChatController>().onFinishText(_actionFinish);
    }



    public ActionTextType actionFinish
    {
        get { return _actionFinish; }
        set { _actionFinish = value; }
    }
}
