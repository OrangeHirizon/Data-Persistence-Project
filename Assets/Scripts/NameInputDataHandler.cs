using System;
using UnityEngine;
using TMPro;

public class NameInputDataHandler : MonoBehaviour
{
    TMP_InputField _inputField;
    private string _inputName;
    [SerializeField] private bool isDebugging;

    private void Start()
    {
        _inputField = GetComponent<TMP_InputField>();
        if (_inputField == null)
            Debug.LogError("NameInputDataHandler: _inputField is null");
    }

    public string GetNameInput()
    {
        return _inputName;
    }

    public void SetInputName()
    {
        _inputName = _inputField.text;
        SaveNameInput(_inputName);
    }

    public void SaveNameInput(string inputName)
    {
        SceneDataManager.Instance.SetInputName(inputName);
        if (isDebugging)
            Debug.Log(SceneDataManager.Instance.GetInputName());
    }
}
