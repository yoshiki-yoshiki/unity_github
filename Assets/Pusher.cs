using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

	// Use this for initialization

	private Vector3 origin;

	void Start () {

		origin = rigidbody.position;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 offset = new Vector3 (0, Mathf.Cos (Time.time), Mathf.Sin (Time.time));
		rigidbody.MovePosition (origin + offset);
	
	}
}
