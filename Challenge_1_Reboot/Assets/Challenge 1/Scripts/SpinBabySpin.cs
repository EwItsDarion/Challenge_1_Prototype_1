/*
     * Darion Jeffries
     * Spin Baby Spin
     * Challenge1
     * Propellors spin!
     */
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpinBabySpin : MonoBehaviour
{
    public float verticalInput;
    public GameObject propeller;
    public float rotationSpeed;
    public float speed;

    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed);

    }

}
