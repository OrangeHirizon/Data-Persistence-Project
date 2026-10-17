using UnityEngine;

public class SceneDataManager : MonoBehaviour
{
    public static SceneDataManager Instance;
    
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
    }

    public int GetBestScore()
    {
        return _bestScore;
    }
}
