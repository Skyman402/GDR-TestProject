using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Circle : MonoBehaviour
{
    public Text couterText;
    public static int point;

    private void Update()
    {
        couterText.text = "Circle picked: " + point;
    }
}
