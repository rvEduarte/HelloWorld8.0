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

            hintText1.text = "C#";
            hintController.number = 0;
            isClicked = true;

    }
}
