using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTextAfterDelay : MonoBehaviour
{
    public float delay = 5f; // seconds

    void Start()
    {
        // Schedule the object to be disabled after delay
        Invoke("HideText", delay);
    }

    void HideText()
    {
        gameObject.SetActive(false);
    }
}