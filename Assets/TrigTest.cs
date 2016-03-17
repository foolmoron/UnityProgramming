using UnityEngine;
using System.Collections;

public class TrigTest : MonoBehaviour {
    public Vector2 A;
    public Vector2 B;

    void Start() {
        Vector2 vectorFromAtoB = A - B;
        float distanceFromAtoB = vectorFromAtoB.magnitude;
        float angleFromAtoB = Mathf.Atan2(vectorFromAtoB.y, vectorFromAtoB.x);

        Vector2 vectorFromBtoA = B - A;
        float distanceFromBtoA = vectorFromBtoA.magnitude;
        float angleFromBtoA = Mathf.Atan2(vectorFromBtoA.y, vectorFromBtoA.x);

        Debug.Log(vectorFromAtoB);
        Debug.Log(distanceFromAtoB);
        Debug.Log(angleFromAtoB);
    }
}
