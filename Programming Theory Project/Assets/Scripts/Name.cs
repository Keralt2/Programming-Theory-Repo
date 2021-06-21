using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public InputField inputField;

    public void OnFieldChange()
    {
        MenuUI.Instance.Name = inputField.text;
    }

}
