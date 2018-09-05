using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementScript : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed;
    public float turnSpeed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(!Input.anyKey)
        {
            return;
        }


        if (Input.GetKey(KeyCode.UpArrow)
            ||
            Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += (gameObject.transform.forward *= movementSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow)
            ||
            Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= (gameObject.transform.forward *= movementSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow)
            ||
            Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, turnSpeed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)
            ||
            Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -turnSpeed, 0);
        }

    }
}