using UnityEngine;
using System.Collections;

public class ObjTest : MonoBehaviour {
    public GameObject AnyObject;
    public MathTest ObjectWithMathTest;

    void Start() {
        Debug.Log(AnyObject);
        Debug.Log(ObjectWithMathTest);
    }
}
