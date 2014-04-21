using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {


	// Use this for initialization
	
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		GameObject original = GameObject.Find ("Coin");
		if(Input.GetKeyDown(KeyCode.C))
		   {
			GameObject copied = Object.Instantiate(original) as GameObject;
		   }

	}
}
