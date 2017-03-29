using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBox : MonoBehaviour {

	float halfwidth = 0f;
	float halfheight = 0f;

	bool isCollision = false;
	string textToShow = "";

	void OnCollisionEnter(Collider hit)
	{
	//	textToShow = hit.textToDisplay;
	//	isCollision = true;
	}

	void OnGUI()
	{
		if (isCollision) {
	//		GUI.TextArea (new Rect ((Screen.width / 2) - halfwidth, (Screen.height / 2) - halfheight, (halfwidth * 2), (halfheight * 2)), textToShow)};
		}
	}

//	void Update()
//		{
	//		if(Input.GetKey(KeyCode.Enter)){isCollision = false;}
		}
	
	//}

