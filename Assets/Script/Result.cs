using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Result : MonoBehaviour {
	public GameObject ui;
	public Text killSnowman;
	public Text round;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.GameOver) {
			ui.SetActive (true);
			Time.timeScale = 0;
		}
		killSnowman.text = SnowmanSpawn.instance.SnowmanKill.ToString ();
		round.text = SnowmanSpawn.instance.round.ToString ();
	}
}
