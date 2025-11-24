using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    public string nextSceneName = "Level 2"; // set in Inspector

    void OnTriggerEnter2D(Collider2D other) // use OnTriggerEnter2D if 2D
    {
        Debug.Log("ExitTrigger detected collision with: " + other.name);
        if (other.CompareTag("Player"))
        {
            // Find the EscapeTimer in the scene and call CompleteLevel
            Debug.Log("Player reached exit. Completing level...");
            FindObjectOfType<EscapeTimer>().CompleteLevel(nextSceneName); 
        }
    }
}