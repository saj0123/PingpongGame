﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoresystem : MonoBehaviour
{
    public static int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        GUI.Box(new Rect(20, 10, 100, 55),"Score" + " " + Score.ToString());

    }
}
