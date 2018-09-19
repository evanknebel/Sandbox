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


    private void OnCollisionEnter(Collision other)
    {
        lerpFloat += 0.1f;
    }



    private void Update()
    {
        lerpFloat = Mathf.Clamp(lerpFloat, 0f, 1f);
        sootiness.SetFloat("_AlbedoLerp", lerpFloat);
        //lerpFloat += lerpFloatSpeed;
    }
}
