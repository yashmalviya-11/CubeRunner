using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalscoretext;
    int myscore = 0;
    void Update()
    {
        scoreText.text = myscore.ToString();
        finalscoretext.text = "SCORE: "+myscore.ToString();
    }
    public void AddScore(int score)
    {
        myscore = myscore + score;
    }
}
