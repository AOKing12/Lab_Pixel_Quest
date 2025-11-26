using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public void RestartLevel()
    {
        // Reload the last gameplay scene
        SceneManager.LoadScene(GameSession.lastLevel); // replace with your actual level name
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Opening scene"); // replace with your menu scene name
    }
}
