using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManagerScript : MonoBehaviour
{
    Animator skeleton;

	// Use this for initialization
	void Start ()
    {
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
        }
        //twerk end
        if (Input.GetKeyUp(KeyCode.R))
        {
            skeleton.SetBool("isTwerk", false);
        }
    }
}
