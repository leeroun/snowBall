using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoving : MonoBehaviour {
	public float Scroll_speed;


	float newOffsetX;
	Material myMaterial;
	// Use this for initialization
	void Start () {
		myMaterial = GetComponent<Renderer> ().material;

	}

	// Update is called once per frame
	void Update () {
		if (AccelerationManager.instance.SnowSpinLeft) {
			newOffsetX = myMaterial.mainTextureOffset.x - (Scroll_speed * Time.deltaTime*Mathf.Abs(Input.acceleration.x));

			Vector2 newOffset = new Vector2 (newOffsetX, 0);
			myMaterial.mainTextureOffset = newOffset;
		} else if (AccelerationManager.instance.SnowSpinRight) {
			newOffsetX = myMaterial.mainTextureOffset.x + (Scroll_speed * Time.deltaTime*Mathf.Abs(Input.acceleration.x));

			Vector2 newOffset = new Vector2 (newOffsetX, 0);
			myMaterial.mainTextureOffset = newOffset;
		}


	}
}
