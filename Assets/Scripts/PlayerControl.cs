using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	Transform pos;

	// Use this for initialization
	void Start () {

		pos = GetComponent <Transform> ();

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			pos.Translate (new Vector3 (0, Time.deltaTime * 3, 0));
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			pos.Translate (new Vector3 (0, -Time.deltaTime * 3, 0));
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			pos.Translate (new Vector3 (-Time.deltaTime * 3, 0, 0));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			pos.Translate (new Vector3 (Time.deltaTime * 3, 0, 0));
		}

	}
}
