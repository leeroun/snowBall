using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
	public static SoundManager instance;

	public AudioClip Button;

	public AudioClip SnowWalk;

	public AudioClip SnowTouch;

	public AudioClip bgm;

	public AudioClip canon;

	public AudioSource BGM;

	public AudioSource EFXSource;
	// Use this for initialization
	void Start () {
		if (instance != null) {
			Destroy (this.gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		}
	}
	public void PlaySingle(AudioClip clip) {
		EFXSource.clip = clip;
		EFXSource.Play ();
	}

	public void PlayBGM(AudioClip clip, bool loop= false) {
		BGM.clip = clip;
		BGM.loop = loop;
		BGM.Play ();
	}


}
