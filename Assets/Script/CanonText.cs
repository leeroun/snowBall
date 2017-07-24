using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanonText : MonoBehaviour {
	public Text BulletCount;
	public Text Damege;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		BulletCount.text = ": "+CanonStack.instance.CanonQueue.Count.ToString ();
		if (CanonStack.instance.CanonQueue.Count == 0) {
			Damege.text = ": 0";
		} else {
			Damege.text = ": " + CanonStack.instance.CanonQueue.Peek ().ToString ();
		}
	}
}
