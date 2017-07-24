using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {
	public static GM instance;
	public bool SnowBallMoving= false;
	// Use this for initialization
	void Start () {
		instance = this;
	}
}
