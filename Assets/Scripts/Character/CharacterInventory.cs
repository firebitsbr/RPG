using UnityEngine;
using System.Collections;

public class CharacterInventory : MonoBehaviour
{
	
	int[] itens;
	// Use this for initialization
	void Start ()
	{
		itens = new int[20];
	}
	public void addItem(int num) {
		itens[num]++;
		//Debug.Log(itens[num]);
	}
	public bool removeItem(int num) {
		if(itens[num] > 0) {
			itens[num]--;
			return true;
		} 
		return false;
	}

	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

