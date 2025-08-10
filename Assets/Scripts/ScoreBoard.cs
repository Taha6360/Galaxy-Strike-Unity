using System.Drawing;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] TMP_Text ScoreBoardText;
    int score = 0;
    public void IncreaseScore(int point)
    {
        score += point;
        ScoreBoardText.text = score.ToString();
    }
}
