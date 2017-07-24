using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour {

	public GameObject snowBall;
	public float dist;
	public static Char instance;
		
	void Awake(){
		instance = this;
	}

	void Start(){

		transform.Translate (new Vector2 (snowBall.transform.position.x + snowBall.transform.localScale.x, 0));
	}
	public void leftBall(){
		dist = Mathf.Abs (transform.position.x-snowBall.transform.position.x);   
		transform.Translate (new Vector3 (-dist/5, 0,-3));

		Vector3 scale = transform.localScale;
		scale.x = -Mathf.Abs (scale.x);
		transform.localScale = scale;
	}
	public void rightBall(){
		dist = Mathf.Abs (snowBall.transform.position.x-transform.position.x);   
		transform.Translate (new Vector3 (dist/5, 0,-3));

		Vector3 scale = transform.localScale;
		scale.x = Mathf.Abs (scale.x);
		transform.localScale = scale;
	}
}
