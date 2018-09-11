using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerScript : MonoBehaviour
{
    int fireColor;

    public ParticleSystem flame;

    Color myOrange;

	// Use this for initialization
	void Start ()
    {
        fireColor = 2;

        //myOrange = new Color(248, 118, 0, 255);3
        myOrange = new Color(0.97254902f, 0.4627451f, 0, 1);
    }


    public void ColorChange()
    {
        if(fireColor == 1)
        {
            flame.startColor = myOrange;
            fireColor++;
        }
        else if(fireColor == 2)
        {
            flame.startColor = Color.green;
            fireColor--;
        }
    }














    private void Update()
    {
        
    }
}
