using UnityEngine;

public class Circle : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameData.AddCircle();
            Destroy(gameObject);
        }
    }
}
