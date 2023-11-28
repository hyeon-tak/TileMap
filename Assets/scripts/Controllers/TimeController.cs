using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{

    public Text TimeText;



    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentDate();
    }
    public void GetCurrentDate()
    {

        string currentTime = DateTime.Now.ToString("HH:mm:ss");
        TimeText.text = currentTime;
    }
}
