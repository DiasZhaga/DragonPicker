using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem; // ✅ Using the new Input System

public class Pause : MonoBehaviour
{
    private bool paused = false;
    public GameObject panel;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (!paused)
            {
                Time.timeScale = 0;
                paused = true;
                panel.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                paused = false;
                panel.SetActive(false);
            }
        }

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            if (currentSceneIndex > 0) // ✅ Prevents loading a negative index
            {
                SceneManager.LoadScene(currentSceneIndex - 1);
            }
            else
            {
                Debug.LogWarning("No previous scene to load!"); // ✅ Logs a warning instead of crashing
            }
        }
    }
}
