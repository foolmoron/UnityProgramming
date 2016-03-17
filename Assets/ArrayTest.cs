using UnityEngine;
using System.Collections;

public class ArrayTest : MonoBehaviour {
    public int[] NumbersToAddUp;

    void Start() {
        int sum = 0;
        foreach (int number in NumbersToAddUp) {
            sum = sum + number;
        }
        Debug.Log("Total sum is: " + sum);

        int loops = 0;
        bool keepLooping = true;
        while (keepLooping) {
            loops = loops + 1;
            keepLooping = Random.value > 0.05f; // 5% random chance of being false
        }
        Debug.Log("Total loops was: " + loops);
    }
}
