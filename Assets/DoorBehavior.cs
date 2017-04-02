using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorBehavior : MonoBehaviour {

	public string nameOfKeyToMakeDoorWork;
	public string nameOfLevelToLoadWhenIGoThroughDoor;

	public Vector2 whereIShouldBeWhenIGoThroughDoor;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.transform.root.gameObject.name == "playergd") {
			GameObject myInvGO = GameObject.FindGameObjectWithTag ("Inventory");
			Inventory myInv = myInvGO.GetComponent<Inventory> ();
			for (int i = 0; i < myInv.actualItems.Length; i++) {
				if (myInv.actualItems [i] != null) {
					if (myInv.actualItems [i].name == nameOfKeyToMakeDoorWork) {
						Debug.Log ("I have a " + nameOfKeyToMakeDoorWork);

						SceneManager.LoadScene (nameOfLevelToLoadWhenIGoThroughDoor);
						Destroy(myInv.actualItems[i]);
						other.transform.root.position = whereIShouldBeWhenIGoThroughDoor;
					}
				}
			}
		}
	}
}
