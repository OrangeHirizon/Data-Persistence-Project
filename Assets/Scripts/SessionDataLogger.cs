using System.IO;
using UnityEngine;

public class SessionDataLogger : MonoBehaviour
{
    public static SessionDataLogger Instance;
    private string _bestScoreName;
    private int _bestScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadSavedData();
    }

    public int GetBestScore()
    {
        return _bestScore;
    }

    public string GetBestScoreName()
    {
        return _bestScoreName;
    }

    public void SetBestScoreData(int score, string bestScoreName)
    {
        _bestScore = score;
        _bestScoreName = bestScoreName;
        SaveBestScore();
    }

    public void LoadSavedData()
    {
        if (File.Exists(Application.persistentDataPath + "/saveData.json"))
        {
            string json = File.ReadAllText(Application.persistentDataPath + "/saveData.json");
            SaveData saveData = JsonUtility.FromJson<SaveData>(json);
            _bestScore = saveData.points;
            _bestScoreName = saveData.playerName;
        }
        else
        {
            _bestScore = 0;
            _bestScoreName = "XXXX";
        }
    }

    public void SaveBestScore()
    {
        SaveData saveData = new SaveData();
        saveData.playerName = _bestScoreName;
        saveData.points = _bestScore;
        
        string json = JsonUtility.ToJson(saveData);
        
        File.WriteAllText(Application.persistentDataPath + "/saveData.json", json);
    }
    
}
