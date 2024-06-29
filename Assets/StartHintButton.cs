using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartHintButton : MonoBehaviour
{
    public Button Button;
    public bool isClicked = false;

    public hintController hintController;

    public TextMeshProUGUI hintText1;
    void Start()
    {
        Button btn = Button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TaskOnClick()
    {
        string size = "50";
        string font = "Bangers SDF";
        string color = "red";
        hintText1.text = "<size=" +size+ ">"+ "<font=" +font+ ">" + "C# Printing Text</font></size><color=" + color + ">" + "\n\nWrite</color> - is like typing words on a typewriter without pressing Enter. It just keeps adding words next to each other on the same line.";
        hintController.number = 0;
        isClicked = true;

    }
}
