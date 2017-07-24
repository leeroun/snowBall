using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMove : MonoBehaviour {

	public void NextScene() {
		SoundManager.instance.PlaySingle (SoundManager.instance.Button);
		SceneManager.LoadScene ("GameScene");
	}
}
