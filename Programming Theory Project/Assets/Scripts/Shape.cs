using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TMP_Text nameField;
    public TMP_Text label;
    public string Name {get ; set;}


    public virtual void DisplayText() {
        label.text = "Just an abstract shape";
    }

     private void OnMouseDown() {
        DisplayText();
    }
}
