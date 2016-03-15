using UnityEngine;
using System.Collections;

public class MathTest : MonoBehaviour {
	public int TestNumber = 49;

	void Start() {
		int number = 5;
		Debug.Log(triple(number));
		Debug.Log(triple(19));
		Debug.Log(triple(TestNumber));

	}

	public int triple(int number) {
		int tripleOfNumber = number * 3;
		return tripleOfNumber;
	}
}
