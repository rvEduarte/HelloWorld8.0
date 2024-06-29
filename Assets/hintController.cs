using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class hintController : MonoBehaviour
{
    public TextMeshProUGUI hintText1;

    public int number;

    public StartHintButton startHintButton;

    public void RightButton()
    {
        Debug.Log(number);
        Debug.Log(startHintButton.isClicked);

        if (startHintButton == true)
        {
            if (number == 0)
            {
                hintText1.text = "WRITE";
                number++;
            }
            else if(number == 1)
            {
                hintText1.text = "WRITELINE";
            }
            else
            {
                Debug.Log("out of number RIGHT");
            }
        }
    }

    public void LeftButton()
    {
        Debug.Log(number);
        if (startHintButton.isClicked == true)
        {
            if(number == 0)
            {
                hintText1.text = "C#";
                //number--;
            }

            else if (number == 1)
            {
                hintText1.text="WRITE";
                number--;
            }
            else
            {
                Debug.Log("Out of number LEFT");
            }
        }
    }
}
