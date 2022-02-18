using UnityEngine;

public class Square : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag.Equals( "Circle"))
        {
            Destroy(collision.gameObject);
        }
    }

    private Vector2 GetMousePos()
    {
        var mousePos=_camera.ScreenToWorldPoint(Input.mousePosition);
        return mousePos;
    }
}
