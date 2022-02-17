using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Square : MonoBehaviour
{
    public static event Action CirclePicked = delegate { };
    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos();
    }

    Vector2 GetMousePos()
    {
        var mousePos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return mousePos;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag.Equals( "Enemy"))
        {
            CirclePicked();
            Destroy(collision.gameObject);
        }
    }
    
}
