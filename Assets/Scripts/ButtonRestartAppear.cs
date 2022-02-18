using UnityEngine;

public class ButtonRestartAppear : MonoBehaviour
{
    [SerializeField] private GameObject _button;

    private void Start()
    {
        _button.SetActive(false);
    }

    private void Update()
    {
        if (GameData.CirclesCount == 5)
        {
            _button.SetActive(true);
        }
    }
}
