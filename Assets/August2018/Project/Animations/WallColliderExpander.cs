using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColliderExpander : MonoBehaviour
{
    public Animator animations;

    BoxCollider animationBarrier;

    public bool bigboy;
    public float tempValueCenter;
    public float maxValueCenter;
    public float tempValueSize;
    public float maxValueSize;

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
            tempValueCenter = 0f;
            tempValueSize = 0f;
        }
        else
        {
            if(tempValueCenter < maxValueCenter)
            {
                tempValueCenter += maxValueCenter * Time.deltaTime;
            }
            if (tempValueSize < maxValueSize)
            {
                tempValueSize += maxValueSize * Time.deltaTime;
            }
            animationBarrier.center = new Vector3(0, tempValueCenter, 0);
            animationBarrier.size = new Vector3(10, tempValueSize, 10);
        }


    }
}
