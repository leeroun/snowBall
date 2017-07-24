using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSnow : MonoBehaviour {
	public float speed= 0.2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GM.instance.SnowBallMoving) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}
		if (transform.position.x < -12) {
			transform.position = new Vector3 (25, transform.position.y, transform.position.z);
		}
	}
}
