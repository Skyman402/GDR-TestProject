using UnityEngine;
using UnityEngine.UI;


public class ScoreUI : MonoBehaviour
{
    public Text couterText;

    private void Update()
    {
        couterText.text = "Circle picked: " + GameData.CirclesCount;
    }
}
