using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Snowman : MonoBehaviour {
	public float Snowman_Speed;
	public int Hp;
	public int divideHP;
	public Slider Hpbar;
	Animator ani;
	// Use this for initialization
	void Start () {
		Hp = Random.Range (3, 6);
		ani = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Snowman_Speed * Time.deltaTime);
		Hpbar.value = (Hp / divideHP) * 100;

		if (Hp <= 0) {
			StartCoroutine (death ());

		} else {
			ani.SetBool ("Death", false);
		}
	}

	IEnumerator death() {
		transform.position += new Vector3 (0, -0.005f, 0);
		ani.SetBool ("Death", true);
		yield return new WaitForSeconds (1.0f);
		SnowmanSpawn.instance.SnowmanKill++;
		gameObject.SetActive (false);
	}

}
