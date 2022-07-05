using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float rotationSpeed = 5000;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float angle = mouseX * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, angle, 0);
    }
}
