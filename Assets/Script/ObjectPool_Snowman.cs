using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool_Snowman : MonoBehaviour {
	public static ObjectPool_Snowman instance;
	public List<GameObject> Objs_Snowman;
	public GameObject Play_Snowman;
	public GameObject Snowman;
	public int Snowman_Amount= 10;


	// Use this for initialization
	void Start () {
		instance = this;
		Objs_Snowman = new List<GameObject> ();
		for (int i = 0; i < Snowman_Amount; i++) {
			GameObject obj_Snowman = (GameObject)Instantiate (Snowman);
			obj_Snowman.transform.parent = Play_Snowman.transform;
			obj_Snowman.SetActive (false);
			Objs_Snowman.Add (obj_Snowman);
		}

	}
	public GameObject GetPooledObject_Snowman() {
		for (int i = 0; i < Snowman_Amount; i++) {
			if (!Objs_Snowman [i].activeInHierarchy) {
				return Objs_Snowman [i];
			}
		}
		return null;
 	}
}
