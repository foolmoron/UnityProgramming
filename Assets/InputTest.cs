using UnityEngine;
using System.Collections;

public class InputTest : MonoBehaviour {
    public float TimeHeld;

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Left mouse clicked!");
        } else if (Input.GetMouseButtonUp(0)) {
            Debug.Log("Left mouse released!");
        } else if (Input.GetMouseButton(0)) {
            Debug.Log("Mouse held down as position: " + Input.mousePosition);
        }
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Key pressed!");
        } else if (Input.GetKeyUp(KeyCode.Space)) {
            TimeHeld = 0;
            Debug.Log("Key released!");
        } else if (Input.GetKey(KeyCode.Space)) {
            TimeHeld += Time.deltaTime;
            Debug.Log("Key held down for: " + TimeHeld + "s");
        }
    }

void Start()
{
    float x = 0f;
    float y = 10f;
    float z = 5.7f;
    Vector2 position2d = new Vector2(x, y);
    Vector3 position3d = new Vector3(x, y, z);
}
public class LifecycleTest : MonoBehaviour
{
    public bool OnUpdate;
    public bool OnLateUpdate;
    public int frameNumber;
}

}

