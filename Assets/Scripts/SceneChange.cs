using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    NameInputDataHandler _inputNameHandler;

    private void Start()
    {
        _inputNameHandler = FindFirstObjectByType<NameInputDataHandler>();
        if (_inputNameHandler == null)
            Debug.LogError("Could not find NameInputDataHandler!");
    }

    public void ChangeScene()
    {
        if (_inputNameHandler.GetNameInput() == null)
        {
            return;
        }
        SceneManager.LoadScene("main");
    }
}
