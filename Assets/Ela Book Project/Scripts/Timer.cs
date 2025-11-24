using UnityEngine;
using UnityEngine.UI;

public class EscapeTimer : MonoBehaviour
{
    public float timeLimit = 60f; // seconds
    private float timeRemaining;
    public Text timerText; // UI element for countdown

    private bool levelComplete = false;

    void Start()
    {
        timeRemaining = timeLimit;
    }

    void Update()
    {
        if (!levelComplete)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerUI();

            if (timeRemaining <= 0)
            {
                levelComplete = true;
                GameManager2.instance.GameOver(); // Call GameManager2
            }
        }
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.Ceil(timeRemaining).ToString();
        }
    }

    public void CompleteLevel(string nextSceneName)
    {
        levelComplete = true;
        GameManager2.instance.LoadNextLevel(nextSceneName);
    }
}