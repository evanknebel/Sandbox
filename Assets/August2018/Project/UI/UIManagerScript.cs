using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManagerScript : MonoBehaviour
{
    int fireColorToggle;
    float fireColorSlide;

    public ParticleSystem flame;
    public Slider slider;

    Color myOrange;
    Color myGreen;

    Color tempMyOrange;
    Color tempMyGreen;

    // Use this for initialization
    void Start ()
    {
        fireColorToggle = 2;

        fireColorSlide = 0;

        //myOrange = (248, 118, 0, 255)
        myOrange = new Color(0.97254902f, 0.4627451f, 0, 1);
        //myGreen = (0, 255, 0, 255)
        myGreen = new Color(0, 1, 0, 1);
    }


    public void ColorChangeToggle()
    {
        if (fireColorToggle == 1)
        {
            flame.startColor = myOrange;
            fireColorToggle++;
            slider.value = 0;
        }
        else if(fireColorToggle == 2)
        {
            flame.startColor = myGreen;
            fireColorToggle--;
            slider.value = 1;
        }
    }

    public void ColorChangeSlide()
    {
        tempMyOrange = new Color(myOrange.r * (1 - slider.value), myOrange.g * (1 - slider.value), myOrange.b * (1 - slider.value), myOrange.a * (1 - slider.value));
        tempMyGreen = new Color(myGreen.r * slider.value, myGreen.g * slider.value, myGreen.b * slider.value, myGreen.a * slider.value);

        flame.startColor = new Color (tempMyGreen.r + tempMyOrange.r, tempMyGreen.g + tempMyOrange.g, tempMyGreen.b + tempMyOrange.b, tempMyGreen.a + tempMyOrange.a);
    }
}
