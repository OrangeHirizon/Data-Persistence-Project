using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    private Text _bestScoreText;
    private int _bestScore;
    private string _nameBestScore;

    private void Awake()
    {
        _bestScoreText = GetComponent<Text>();
        if (_bestScoreText == null)
        {
            Debug.LogError("BestScoreText is NULL");
        }
    }

    public void SetNewScore(int score)
    {
        _bestScore = score;
        UpdateBestScore();
    }

    public void UpdateBestScore()
    {
        _bestScoreText.text = "Best Score: " + _nameBestScore + " : " + _bestScore;
    }

    private void Start()
    {
        GetScoreData();
    }

    private void GetScoreData()
    {
        _bestScore = SessionDataLogger.Instance.GetBestScore();
        _nameBestScore = SessionDataLogger.Instance.GetBestScoreName();
        UpdateBestScore();
    }
}
