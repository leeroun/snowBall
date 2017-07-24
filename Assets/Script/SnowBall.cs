using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour {
	public float Angle;
	public float spinCount= 1f;
	public float MoveSpeed= 3f;
	public int ballScaleCount = 0;



	// Update is called once per frame


	void Update () {
		
		if (ballScaleCount < 5 && !AccelerationManager.instance.ShakeCheck) {
			if (Input.acceleration.x > 0.1) {	
				transform.Rotate (new Vector3 (0, 0, -Time.deltaTime * Angle * Input.acceleration.x));
				AccelerationManager.instance.SnowSpinRight = true;
				AccelerationManager.instance.SnowSpinLeft = false;
				SoundManager.instance.PlaySingle (SoundManager.instance.SnowWalk);
			} else if (Input.acceleration.x < -0.1) {	
				transform.Rotate (new Vector3 (0, 0, Time.deltaTime * Angle * Mathf.Abs (Input.acceleration.x)));
				AccelerationManager.instance.SnowSpinLeft = true;
				AccelerationManager.instance.SnowSpinRight = false;
				SoundManager.instance.PlaySingle (SoundManager.instance.SnowWalk);
			} else {
				AccelerationManager.instance.SnowSpinRight = false;
				AccelerationManager.instance.SnowSpinLeft = false;
			}
			if (AccelerationManager.instance.SnowSpinRight || AccelerationManager.instance.SnowSpinLeft) {
				if (AccelerationManager.instance.SnowStackUp) {
					if (spinCount > 0) {
						spinCount -= Time.deltaTime;
					} else {
						spinCount = 1f;
						transform.localScale += new Vector3 (0.01f, 0.01f, 0.01f);

						ballScaleCount++;
						AccelerationManager.instance.SnowHP--;

					}
				}
			}
		} else {
			AccelerationManager.instance.SnowSpinRight = false;
			AccelerationManager.instance.SnowSpinLeft = false;
		}
	}

	void OnMouseDown() {
		if (ballScaleCount != 0) {
			transform.localScale = new Vector3 (0.05f, 0.05f, 0.05f);
			SoundManager.instance.PlaySingle (SoundManager.instance.SnowTouch);
			CanonStack.instance.CanonQueue.Enqueue (ballScaleCount);
			ballScaleCount = 0;
		}
	}
}
