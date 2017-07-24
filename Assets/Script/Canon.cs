using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {
	public GameObject bullet;
	public Transform firePoint;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Snowman") {
			GameManager.instance.GameOver = true;
		}
	}

	public void Shoot() {
		if (CanonStack.instance.CanonQueue.Count != 0) {
			GameObject Obj_bullet = (GameObject)Instantiate (bullet, firePoint.position, Quaternion.identity);
			SoundManager.instance.PlaySingle (SoundManager.instance.canon);
			Obj_bullet.GetComponent<BulletSnow> ().damage = CanonStack.instance.CanonQueue.Dequeue ();
			Destroy (Obj_bullet, 5.0f);
		}
	}
}
