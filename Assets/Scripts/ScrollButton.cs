using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollButton : MonoBehaviour
{
    [SerializeField] private GameObject button;

    private void Start()
    {
        button.SetActive(false);
    }

    private void Update()
    {
        if (Circle.point == 5)
        {
            button.SetActive(true);
        }
    }
}
