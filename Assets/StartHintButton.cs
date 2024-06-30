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
        string value = "<size=50> <font=Bangers SDF>C# Printing Text\n\n</font></size><color=red>Write</color> - is like typing words on a typewriter without pressing Enter. It just keeps adding words next to each other on the same line.";
        hintText1.text = value;
        hintController.number = 0;
        isClicked = true;

    }
}
