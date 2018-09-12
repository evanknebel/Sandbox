using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementScript : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed;
    public float turnSpeed;

    public bool canMove;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        canMove = false;
    }

    private void Update()
    {
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.transform.position += (gameObject.transform.forward *= movementSpeed);
            }
            //if (Input.GetKey(KeyCode.DownArrow))
            //{
            //    gameObject.transform.position -= (gameObject.transform.forward *= movementSpeed);
            //}

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, turnSpeed, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, -turnSpeed, 0);
            }
        }
    }
}