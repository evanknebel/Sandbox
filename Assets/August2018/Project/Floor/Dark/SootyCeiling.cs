using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SootyCeiling : MonoBehaviour
{
    public Material sootiness;
    public float lerpFloat;
    public float lerpFloatSpeed;

    private void Start()
    {
        lerpFloat = 0;
    }


    private void OnParticleCollision(GameObject smoke)
    {
        if (smoke.gameObject.tag == "Smoke")
        {
            lerpFloat += lerpFloatSpeed;
    }
}



    private void Update()
    {
        lerpFloat = Mathf.Clamp(lerpFloat, 0f, 1f);
        sootiness.SetFloat("_AlbedoLerp", lerpFloat);
        //lerpFloat += lerpFloatSpeed;
    }
}
