using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour {

	void Awake ()
	{
		DontDestroyOnLoad(this.gameObject);
	}
}
