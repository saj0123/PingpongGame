using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int Scoredisplayed = 0;


    private void OnGUI()
    {
        
        GUI.Box(new Rect(10, 100, 100, 100), Scoredisplayed.ToString());
    }


}
