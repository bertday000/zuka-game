using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    void Start()
    {
        textMeshProUGUI.text = "Score: " + score.ToString();
    }
    public void IncreaseScore()
    {
        score = score + 100;
        textMeshProUGUI.text = "Score: " + score.ToString();
    } 
}
