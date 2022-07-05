using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;

    public CharacterController controller;
    void Start()
    {

    }

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        Vector3 direction = transform.forward * vInput + transform.right * hInput;
        controller.SimpleMove(direction.normalized * speed);
    }

}
