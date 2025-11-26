using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // or using TMPro if you prefer TextMeshPro

public class SignDialog : MonoBehaviour
{
    public GameObject dialogBox;   // UI panel
    public Text dialogText;        // legacy UI.Text (or TextMeshProUGUI if using TMP)
    [TextArea(2, 5)]
    public string[] messages;      // assign multiple lines in Inspector

    private int currentIndex = 0;
    private bool playerInRange = false;
    private bool dialogActive = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!dialogActive)
            {
                // Start dialog
                dialogBox.SetActive(true);
                dialogActive = true;
                currentIndex = 0;
                dialogText.text = messages[currentIndex];
            }
            else
            {
                // Advance to next message
                currentIndex++;
                if (currentIndex < messages.Length)
                {
                    dialogText.text = messages[currentIndex];
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
            dialogActive = false;
        }
    }
}

