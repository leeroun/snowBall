using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationManager : MonoBehaviour {
	public static AccelerationManager instance;

	public bool ShakeCheck = false;

	public bool SnowSpinLeft = false;
	public bool SnowSpinRight = false;

	public bool SnowStackUp= false;

	public int SnowHP = 10;

	float accelerometerUpdateInterval = 1.0f / 60.0f;
	float lowPassKernelWidthInSeconds= 1.0f;
	float shakeDetectionThreshold= 1.0f;

	float lowPassFilterFactor;
	Vector3 lowPassValue;
	// Use this for initialization
	void Start () {
		instance = this;
		lowPassFilterFactor = accelerometerUpdateInterval / lowPassKernelWidthInSeconds;
		shakeDetectionThreshold *= shakeDetectionThreshold;
		lowPassValue = Input.acceleration;

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 acceleration = Input.acceleration;
		lowPassValue = Vector3.Lerp (lowPassValue, acceleration, lowPassFilterFactor);
		Vector3 deltaAcceleration = acceleration - lowPassValue;

		if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold)
			ShakeCheck = true;
		else
			ShakeCheck = false;
	}
}
