using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundFloor : MonoBehaviour {
	public Sprite[] sprite;
	public float ShakeTime = 2f;
	SpriteRenderer SR;
	Material Mt;
	// Use this for initialization
	void Start () {
		SR = GetComponent<SpriteRenderer> ();
		Mt = GetComponent<Renderer> ().material;

	}
	
	// Update is called once per frame
	void Update () {
		if (AccelerationManager.instance.SnowHP == 0) {
			SR.sprite = sprite [0];

			AccelerationManager.instance.SnowStackUp = false;
		}
		if (AccelerationManager.instance.ShakeCheck) {
			ShakeTime -= Time.deltaTime;
			if (ShakeTime < 0) {
				ShakeTime = 2f;
				AccelerationManager.instance.SnowHP = 10;
				SR.sprite = sprite [1];

				AccelerationManager.instance.SnowStackUp = true;
			}
		}
	}
}
