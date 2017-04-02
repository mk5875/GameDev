using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public GameObject[] actualItems;

	private GameObject[] items;
	private Vector3[] itemPos;
	private LayerMask layerMask = (1 << 8);//8th layer mask to use
	private int itemIndexNow =0;
	public Transform playerTrans;
	public Transform doorTrans1;
	public Transform doorTrans2;
	public Transform doorTrans3;
	public Transform doorTrans4;
	public Transform doorTrans5;

	//items: key, cake, hat, cat, dog, makeup box
	// Use this for initialization
	void Start () {
		actualItems = new GameObject[6];

		items = new GameObject[6];//gameobject
		itemPos = new Vector3[6];//position of gameobject

		for (int i = 0; i < transform.childCount; i++) {
			items [i] = transform.GetChild (i).gameObject;
			itemPos [i] = transform.GetChild (i).transform.position; //store position of all items in inventory
		}
	}
	
	// Update is called once per frame
	void Update () {
		//OpenDoor ();
		ClickAction ();
		SetMyIcons ();
	}
	/*public void OpenDoor()
	{
		//check if we clicked the key icon in panel
		if (Input.GetMouseButtonDown (0) && EventSystem.current.IsPointerOverGameObject())
		{ //press mouse and will turn true if pointer over ui
			
			if(Vector3.Distance(playerTrans.position,doorTrans1.position)<= .5f)
			{
				Debug.Log ("First if");
				Destroy(doorTrans1.gameObject);
				items [0].SetActive (false);
				itemIndexNow--;
			}
			if(Vector3.Distance(playerTrans.position,doorTrans2.position)<= .5f)
			{
				Debug.Log ("2 if");

				Destroy(doorTrans2.gameObject);
				items [1].SetActive (false);
				itemIndexNow--;
			}
			if(Vector3.Distance(playerTrans.position,doorTrans3.position)<= .5f)
			{
				Debug.Log ("3 if");

				Destroy(doorTrans3.gameObject);
				items [2].SetActive (false);
				itemIndexNow--;
			}
			if(Vector3.Distance(playerTrans.position,doorTrans4.position)<= .5f)
			{
				Debug.Log ("4 if");

				Destroy(doorTrans2.gameObject);
				items [4].SetActive (false);
				itemIndexNow--;
			}
			if(Vector3.Distance(playerTrans.position,doorTrans5.position)<= .5f)
			{
				Debug.Log ("5 if");

				Destroy(doorTrans5.gameObject);
				items [5].SetActive (false);
				itemIndexNow--;
			}
		}

		//to check if we are close enough to the door

		//if so we open door

	}

*/
	void ClickAction ()
	{
		if (Input.GetMouseButtonDown (0) && !EventSystem.current.IsPointerOverGameObject()) { //press mouse and will turn true if pointer over ui
			RaycastHit2D hit; //object that stores the things that I use my ray to hit (null if i I don't hit anything)
			hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero, 0f, layerMask, -10, 10); //where the point starts, aims, and only have layermask area be affected

			if (hit.collider != null) {
				//GameObject go;
				if (hit.transform.root.gameObject.tag == "Key") {
					//Destroy (hit.collider.gameObject);
					for (int i = 0; i < 6; i++) {
						if (i == 5 && actualItems [i] != null) {
							Debug.Log ("Inventory full");
							return;
						}

						if (actualItems [i] == null) {
							actualItems [i] = hit.transform.root.gameObject;
							actualItems [i].GetComponent<SpriteRenderer> ().enabled = false;
							actualItems [i].GetComponent<Collider2D> ().enabled = false;
							return;
						} else {
							continue;
						}
					}
					//go = items [itemIndexNow];
					//if (itemIndexNow >= itemPos.Length)
					//	return;
					//go.transform.position = itemPos [itemIndexNow]; 
					//itemIndexNow++;

					//go.SetActive (true);
				}

				Debug.Log ("i don't know what it is");
			}
		}

		//items [itemIndexDesired].SetActive (true); //set desired gameobject to active
	}

	void SetMyIcons()
	{
		for (int i = 0; i < 6; i++) {
			if (actualItems [i] != null) {
				items [i].SetActive (true);
			} else {
				items [i].SetActive (false);
			}
		}			
	}
}

