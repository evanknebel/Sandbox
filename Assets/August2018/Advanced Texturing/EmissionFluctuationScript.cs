using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionFluctuationScript : MonoBehaviour
{
    float intensity = 5.0f;
    public Material mat;

    bool glowBrighter;

    public float glowSpeed;

    public float glowLow;
    public float glowHigh;

	void Update ()
    {
        mat.EnableKeyword("_EMMISION");
        mat.SetColor("_EmissionColor", new Color(1.0f, 1.0f, 1.0f, 1.0f) * intensity);

        if (intensity <= glowLow)
        {
            glowBrighter = true;
        }
        else if (intensity >= glowHigh)
        {
            glowBrighter = false;
        }

        if (glowBrighter == true)
        {
            intensity += 1f * Time.deltaTime * glowSpeed;
        }
        else
        {
            intensity -= 1f * Time.deltaTime * glowSpeed;
        }
        
    }
}
