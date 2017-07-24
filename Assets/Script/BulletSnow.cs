using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSnow : MonoBehaviour {
	public float bulletSpeed;
	public int damage;
	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Snowman") {
			col.gameObject.GetComponent<Snowman> ().Hp -= damage;
			Destroy (this.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * bulletSpeed * Time.deltaTime);
	}
}
