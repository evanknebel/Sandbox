using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColliderExpander : MonoBehaviour
{
    public Animator animations;

    BoxCollider animationBarrier;

    public bool bigboy;

	// Use this for initialization
	void Start ()
    {
        animationBarrier = gameObject.GetComponent<BoxCollider>();
        bigboy = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //idle
        if (!Input.anyKey
            &&
            animations.GetBool("isSitting") == false)
        {
            bigboy = false;
        }

        //dance//
        //swing start
        if (Input.GetKeyDown(KeyCode.W))
        {
            bigboy = true;
        }
        //swing end

        //samba start
        if (Input.GetKeyDown(KeyCode.E))
        {
            bigboy = true;
        }
        //samba end

        //twerk start
        if (Input.GetKeyDown(KeyCode.R))
        {
            bigboy = true;
        }
        //twerk end


        if (bigboy == false)
        {
            animationBarrier.center = new Vector3(0, 0, 0);
            animationBarrier.size = new Vector3(10, 0, 10);
        }
        else
        {
            animationBarrier.center = new Vector3(0, 0.5f, 0);
            animationBarrier.size = new Vector3(10, 2.2f, 10);
        }


    }
}
