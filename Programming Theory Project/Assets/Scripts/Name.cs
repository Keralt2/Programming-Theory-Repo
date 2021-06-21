using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Name : MonoBehaviour
{
    public InputField inputField;

    public void OnFieldChange()
    {
        MenuUI.Instance.Name = inputField.text;
    }

    public void SceneChange()
    {
        SceneManager.LoadScene(1);
    }
}
