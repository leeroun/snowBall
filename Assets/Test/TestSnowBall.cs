using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSnowBall : MonoBehaviour {
	public float baseAngle= 0;
	public float ang;
	public float angl= 20f;
	void Update() {
		if (Input.acceleration.x > 0) {
			transform.Rotate (new Vector3 (0, 0, -Time.deltaTime * angl*Input.acceleration.x));
			GM.instance.SnowBallMoving = true;
		}
		if (Input.acceleration.x < 0) {
			transform.Rotate (new Vector3 (0, 0, Time.deltaTime * angl*Mathf.Abs(Input.acceleration.x)));
			GM.instance.SnowBallMoving = true;
		}
	}

	void OnMouseDown() {
		Vector3 pos = Camera.main.WorldToScreenPoint (transform.position);
		pos = Input.mousePosition - pos;
		baseAngle = Mathf.Atan2 (pos.y, pos.x) * Mathf.Rad2Deg;
	}

	void OnMouseDrag() {
		

		Vector3 pos = Camera.main.WorldToScreenPoint (transform.position);
		pos = Input.mousePosition - pos;
		ang = Mathf.Atan2 (pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;
		transform.rotation = Quaternion.AngleAxis (ang, Vector3.forward);
		GM.instance.SnowBallMoving = true;
	}

	void OnMouseUp() {
		GM.instance.SnowBallMoving = false;
	}


}
