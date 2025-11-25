using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI dialogText;

    void Start()
    {
        // Show initial dialog when level begins
        ShowDialog("I need to escape before time runs out...");
    }

    public void ShowDialog(string message)
    {
        if (dialogText != null)
        {
            dialogText.text = message;
        }
    }
}