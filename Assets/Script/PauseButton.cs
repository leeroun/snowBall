using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseButton : MonoBehaviour {
	public GameObject ui;
	// Use this for initialization
	public void Pause() {
		if (Time.timeScale == 1) {
			ui.SetActive (true);
			SoundManager.instance.PlaySingle (SoundManager.instance.Button);
			Time.timeScale = 0;
		} else {	
			ui.SetActive (false);
			SoundManager.instance.PlaySingle (SoundManager.instance.Button);
			Time.timeScale = 1;
		}
	}
}
