using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    override public void DisplayText() 
    {
        label.text = "I have many pointy corners";
    }
}
