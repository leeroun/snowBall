using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public static GameManager instance;
	public bool GameOver = false;
	// Use this for initialization
	void Start () {
		instance = this;
		SoundManager.instance.PlayBGM (SoundManager.instance.bgm, true);
	}

}
