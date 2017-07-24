using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResultTouchReturn : MonoBehaviour {

	// Use this for initialization
	void Update() {
		if (Input.GetMouseButton (0)) {
			SceneManager.LoadScene ("StartScene");
			Time.timeScale = 1;
		}
	}
}
