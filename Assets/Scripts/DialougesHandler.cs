using UnityEngine;
using TMPro;

public class DialougesHandler : MonoBehaviour
{
    [SerializeField] string[] timeLineNextLines;
    [SerializeField] TMP_Text text;

    int currentline = 0;
    public void nextText()
    {
        currentline++;
        text.text = timeLineNextLines[currentline];
    }
}
