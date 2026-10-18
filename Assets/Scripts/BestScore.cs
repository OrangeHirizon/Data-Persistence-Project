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

    public void UpdateBestScore()
    {
        _bestScoreText.text = "Best Score: " + _nameBestScore + " : " + _bestScore;
    }

    private void Start()
    {
        GetScoreData();
    }

    private void SetBestScoreName(string _name)
    {
        _nameBestScore = _name;
        
    }

    private void GetScoreData()
    {
        _bestScore = SceneDataManager.Instance.GetBestScore();
    }
}
