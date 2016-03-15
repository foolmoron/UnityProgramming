using UnityEngine;
using System.Collections;

public class LifecycleTest : MonoBehaviour {
	
	public bool OnUpdate;
	public bool OnLateUpdate;
	public int frameNumber;
	public GameObject test;
	
	void Awake() {
		Debug.Log("OnAwake");	
	}
	
	void Start() {
		Debug.Log("OnStart");	
	}
	
	void Update() {
		frameNumber++;
		if (OnUpdate) {
			Debug.Log("OnUpdate #" + frameNumber);
		}
	}

	void LateUpdate() {
		if (OnLateUpdate) {
			Debug.Log("OnLateUpdate #" + frameNumber);
		}
	}

	void OnTriggerEnter2D() {
		Debug.Log("OnTriggerEnter2D");
	}

	void OnCollisionEnter2D() {
		Debug.Log("OnCollisionEnter2D");
	}

	void OnDestroy() {
		Debug.Log("OnDestroy");
	}
}