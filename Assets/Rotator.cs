using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	Rigidbody2D mario;

	void Start() {
	
	}
	
	void Update() {
		if (Input.GetKeyDown (KeyCode.A)) {
			mario.velocity = new Vector2(0, 50);
		}
	}
}