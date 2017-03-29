using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionText : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Table")
			coll.gameObject.SendMessage ("Under the table is a key", 20);

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
