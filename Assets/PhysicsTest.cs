using UnityEngine;
using System.Collections;

public class PhysicsTest : MonoBehaviour {
    public Vector3 Acceleration;
    public Vector3 Velocity;

    void Update() {
        Velocity += Acceleration * Time.deltaTime;
        transform.position += Velocity * Time.deltaTime;
    }

public GameObject AnyObject;
public MathTest ObjectWithMathTest;

void Start()
{
    Debug.Log(AnyObject);
    Debug.Log(ObjectWithMathTest);
}
}
