using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
        if (startHintButton == true)
        {
            if (number == 1)
            {
                string size = "50";
                string font = "Bangers SDF";
                string color = "blue";
                hintText1.text = "<size=" + size + ">" + "<font=" + font + ">" + "C# Printing Text</font></size><color=" + color + ">\n\nWriteLine</color> - is like typing words on a typewriter and then pressing Enter after each line. It makes each new set of words start on a fresh line.";
                number++; // VALUE 2
            }
            else if(number == 2)
            {
                string size = "50";
                string font = "Bangers SDF";
                string color = "#EF9A30";
                hintText1.text = "<size=" + size + ">" + "<font=" + font + ">" + "C# Printing Text</font></size> \n\nYou can also output numbers, and perform <color=" + color + "> mathematical calculations"; // VALUE 2    
            }
            else
            {
                Debug.Log("out of number RIGHT");
                Debug.Log(number);
            }
        }
    }

    public void LeftButton()
    {
        Debug.Log(number);
        if (startHintButton.isClicked == true)
        {
            if(number == 1)
            {
                string size = "50";
                string font = "Bangers SDF";
                string color = "red";
                hintText1.text = "<size=" + size + ">" + "<font=" + font + ">" + "C# Printing Text</font></size><color=" + color + ">" + "\n\nWrite</color> - is like typing words on a typewriter without pressing Enter. It just keeps adding words next to each other on the same line.";
            }

            else if (number == 2)
            {
                string size = "50";
                string font = "Bangers SDF";
                string color = "blue";
                hintText1.text = "<size=" + size + ">" + "<font=" + font + ">" + "C# Printing Text</font></size><color=" + color + ">\n\nWriteLine</color> - is like typing words on a typewriter and then pressing Enter after each line. It makes each new set of words start on a fresh line.";
                number--;  //VALUE 1
            }
            else
            {
                Debug.Log("Out of number LEFT");
                Debug.Log(number);
            }
        }
    }
}