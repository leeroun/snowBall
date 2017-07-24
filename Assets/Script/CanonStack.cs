using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonStack : MonoBehaviour {
	public static CanonStack instance;
	public Queue<int> CanonQueue= new Queue<int>();
	// Use this for initialization
	void Start () {
		instance = this;
	}
}
