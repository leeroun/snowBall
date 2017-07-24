using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour {
	public float wheelSpeed = 200f;

	void Update () {
		transform.Rotate (new Vector3 (0, 0, Time.deltaTime * wheelSpeed));
	}
}
