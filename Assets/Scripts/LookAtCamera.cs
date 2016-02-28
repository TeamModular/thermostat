using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {
    private float initialRotation;

    void Start()
    {
        initialRotation = transform.rotation.z;
    }

    void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
        transform.Rotate(Vector3.up * initialRotation * 180); // Fix Rotation (Flipped sprites)
    }
}
