using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Load your first gameplay scene
        SceneManager.LoadScene("Level 1"); // replace with your actual level name
    }

    public void QuitGame()
    {
        Application.Quit(); // works in a built game, not in the editor
    }
}