using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 instance; // Singleton

    public int score = 0;
    public bool isGameOver = false;

    void Awake()
    {
        // Ensure only one GameManager2 exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }

    public void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over!");
        SceneManager.LoadScene("Dead screen"); // Replace with your scene name
    }

    public void LoadNextLevel(string sceneName)
    {
        isGameOver = false;
        SceneManager.LoadScene(sceneName);
    }

    public void RestartGame()
    {
        score = 0;
        isGameOver = false;
        SceneManager.LoadScene("Level1"); // Replace with your starting level
    }
}