using UnityEngine;

public class SessionDataLogger : MonoBehaviour
{
    public static SessionDataLogger Instance;
    private string _bestScoreName;
    private int _inputName;

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
    
    
}
