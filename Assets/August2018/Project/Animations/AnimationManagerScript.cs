using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManagerScript : MonoBehaviour
{
    Animator skeleton;
    PlayerMovementScript movement;

    WallColliderExpander wallCollider;

    // Use this for initialization
    void Start ()
    {
        wallCollider = FindObjectOfType<WallColliderExpander>();
        movement = gameObject.GetComponent<PlayerMovementScript>();
        skeleton = gameObject.GetComponent<Animator>();
        skeleton.SetBool("isIdle", true);
	}
	
	// Update is called once per frame
	void Update ()
    {
        //idle
		if(!Input.anyKey
            &&
            skeleton.GetBool("isSitting") == false)
        {
            skeleton.SetBool("isIdle", true);
            movement.canMove = true;
            wallCollider.bigboy = false;
        }
        else
        {
            skeleton.SetBool("isIdle", false);
        }

        //begin walking
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            skeleton.SetBool("isWalking", true);
        }
        //end walking
        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            skeleton.SetBool("isWalking", false);
        }

        //sitting
        if(Input.GetKeyDown(KeyCode.Q))
        {
            //begin sitting
            if(skeleton.GetBool("isSitting") == false)
            {
                skeleton.SetBool("isSitting", true);
                movement.canMove = false;
            }
            //end sitting
            else
            {
                skeleton.SetBool("isSitting", false);
            }
        }

        //dance//
        //swing start
        if(Input.GetKeyDown(KeyCode.W))
        {
            skeleton.SetBool("isSwing", true);
            movement.canMove = false;
            wallCollider.bigboy = true;
        }
        //swing end
        if (Input.GetKeyUp(KeyCode.W))
        {
            skeleton.SetBool("isSwing", false);
        }
        //samba start
        if (Input.GetKeyDown(KeyCode.E))
        {
            skeleton.SetBool("isSamba", true);
            movement.canMove = false;
            wallCollider.bigboy = true;
        }
        //samba end
        if (Input.GetKeyUp(KeyCode.E))
        {
            skeleton.SetBool("isSamba", false);
        }
        //twerk start
        if (Input.GetKeyDown(KeyCode.R))
        {
            skeleton.SetBool("isTwerk", true);
            movement.canMove = false;
            wallCollider.bigboy = true;
        }
        //twerk end
        if (Input.GetKeyUp(KeyCode.R))
        {
            skeleton.SetBool("isTwerk", false);
        }
    }
}
