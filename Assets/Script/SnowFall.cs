using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFall : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//만약 공이 굴러간다면
		transform.Translate (Vector3.left * speed * Time.deltaTime);
		if (transform.position.x < -10) {
			transform.position = new Vector3 (19, transform.position.y, transform.position.z);
		}
	}
}
