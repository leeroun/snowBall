using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFallShake : MonoBehaviour {
	ParticleSystem PS;
	// Use this for initialization
	void Start () {
		PS = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (AccelerationManager.instance.ShakeCheck) {
			PS.startLifetime = 1;
		} else {
			PS.startLifetime = 0.05f;
		}
	}
}
