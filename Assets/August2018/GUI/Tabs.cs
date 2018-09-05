using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tabs : MonoBehaviour
{
    public int buttons;
    public GameObject ButtonPrefab;
    public Canvas canvas;

    public int lines;

    public int buttonWriting;

    // To Do:
    //  FIGURE OUT ROWS OF BUTTONS WITH FOR LOOPS
    //  


    private void Start()
    {
        lines = buttons / 5;
        Mathf.RoundToInt(lines);
        lines += 1;
        buttonWriting = 1;

        for (int i = 0; i < lines; i++)
        {
            for (int innerI = 0; innerI < buttons; innerI++)
            {
                GameObject button = Instantiate(ButtonPrefab);
                button.transform.parent = this.transform;
                button.GetComponentInChildren<Text>().text = "Button " + (buttonWriting);
                buttonWriting += 1;
                button.GetComponentInChildren<Text>().fontSize = 13;
                button.GetComponent<RectTransform>().sizeDelta = new Vector2((canvas.GetComponent<RectTransform>().sizeDelta.x) / buttons, 30);
                button.transform.position = new Vector2(
                    ((button.GetComponent<RectTransform>().sizeDelta.x) * (innerI + 1)) - (button.GetComponent<RectTransform>().sizeDelta.x / 2), //x
                    canvas.GetComponent<RectTransform>().sizeDelta.y - ((button.GetComponent<RectTransform>().sizeDelta.y / 2) * (i + 1)) //y
                    );
            }
        }
    }




    ///// Old and Simple

    //public Image Panel1;
    //public Image Panel2;

    //// Use this for initialization
    //void Start()
    //{
    //    Panel1.enabled = false;
    //    Panel2.enabled = false;
    //}

    //public void Panel1Enable()
    //{
    //    if (Panel1.enabled == false)
    //    {
    //        Panel1.enabled = true;
    //        Panel2.enabled = false;
    //    }
    //}

    //public void Panel2Enable()
    //{
    //    if (Panel2.enabled == false)
    //    {
    //        Panel2.enabled = true;
    //        Panel1.enabled = false;
    //    }
    //}

    ///// Old and Simple
}
