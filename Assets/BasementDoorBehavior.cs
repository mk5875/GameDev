using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasementDoorBehavior : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.transform.root.gameObject.name == "playergd") {
			GameObject myInvGO = GameObject.FindGameObjectWithTag ("Inventory");
			Inventory myInv = myInvGO.GetComponent<Inventory> ();
			for (int i = 0; i < myInv.actualItems.Length; i++) {
				if (myInv.actualItems [i] != null) {
					if (myInv.actualItems [i].name == "key") {
						Debug.Log ("I have a key");

						SceneManager.LoadScene ("First Floor");
						Destroy(myInv.actualItems[i]);
						other.transform.root.position = new Vector2 (0, -2.34f);
					}
				}
			}
		}
	}
}
