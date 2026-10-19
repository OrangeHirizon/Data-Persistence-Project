using UnityEngine;
using TMPro;

public class SceneDataManager : MonoBehaviour
{
    public static SceneDataManager Instance;
    [SerializeField] private bool isDebugging;
    private string _inputName;

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

    public void SetInputName(string inputName)
    {
        this._inputName = inputName;
        if (isDebugging)
            Debug.Log(SceneDataManager.Instance.GetInputName());
    }
    public string GetInputName()
    {
        return _inputName;
    }
}
