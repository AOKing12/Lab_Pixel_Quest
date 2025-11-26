using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneDialog : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    [TextArea(2, 5)]
    public string[] phoneConversation; // fill in Inspector

    private int currentIndex = -1;
    private bool dialogActive = false;

    void Start()
    {
        dialogBox.SetActive(true);
        dialogText.text = "Ring Ring Ring...\nPress E to pick up.";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!dialogActive)
            {
                // Start conversation
                dialogActive = true;
                currentIndex = 0;
                dialogText.text = phoneConversation[currentIndex];
            }
            else
            {
                // Advance conversation
                currentIndex++;
                if (currentIndex < phoneConversation.Length)
                {
                    dialogText.text = phoneConversation[currentIndex];
                }
                else
                {
                    // End dialog
                    dialogBox.SetActive(false);
                    dialogActive = false;
                }
            }
        }
    }
}

