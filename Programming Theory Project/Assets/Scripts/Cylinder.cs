using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    override public void DisplayText() 
    {
        label.text = "I'm both flat and round at the same time";
    }
}
