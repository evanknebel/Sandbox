using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitchScript : MonoBehaviour
{
    public CinemachineVirtualCamera[] cameras;
    public int cameraNumber;
    public KeyCode[] keyCodes;

	// Use this for initialization
	void Start ()
    {
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].enabled = false;
        }
        cameras[0].enabled = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        int selectedIndex = -1;
        if (Input.anyKeyDown)
        {
            for (int i = 0; i < cameras.Length; i++)
            {
                if (cameras[i].enabled == true)
                {
                    cameraNumber = i;
                }
            }
        }

        // see which one was pressed
        for (int i = 0; i < keyCodes.Length; ++i)
        {
            if(Input.GetKeyDown(keyCodes[i]))
            {
                selectedIndex = i;
            }
        }

        if(selectedIndex == -1)
        {
            return;
        }


        // turn off everything except the one I pressed
        for (int i = 0; i < keyCodes.Length; ++i)
        {
            if(i != selectedIndex
               &&
               i != selectedIndex - cameras.Length)
            {
                if (i >= cameras.Length)
                {
                    cameras[i - cameras.Length].enabled = false;
                }
                else
                {
                    cameras[i].enabled = false;
                }
            }
        }
        if (selectedIndex >= cameras.Length)
        {
            selectedIndex -= cameras.Length;
        }
        if (cameras[selectedIndex].enabled != true)
        {
            cameras[selectedIndex].enabled = true;
        }
    }
}
