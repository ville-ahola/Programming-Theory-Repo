using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : Shape
{
    override public void DisplayText() 
    {
        label.text = "I have infinite pointy corners, sort of";
    }
}
