using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Update()
    {
        // Randomize the rotation angles
        float randomX = Random.Range(0f, 360f);
        float randomY = Random.Range(0f, 360f);
        float randomZ = Random.Range(0f, 360f);

        // Apply the rotation to the GameObject
        transform.Rotate(new Vector3(randomX, randomY, randomZ) * rotationSpeed * Time.deltaTime);
    }
}
