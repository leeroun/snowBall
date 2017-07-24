using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovingBackGround : MonoBehaviour {
	public float Scroll_speed = 1f;
	float newOffsetX;
	Material myMaterial;
	// Use this for initialization
	void Start () {
		myMaterial = GetComponent<Renderer> ().material;
	}
	
	// Update is called once per frame
	void Update () {
		if(GM.instance.SnowBallMoving)
        {
			newOffsetX = myMaterial.mainTextureOffset.x + Scroll_speed * Time.deltaTime;

			Vector2 newOffset = new Vector2 (newOffsetX, 0);
			myMaterial.mainTextureOffset = newOffset;
        }
	}
}
