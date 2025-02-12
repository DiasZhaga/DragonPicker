using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ✅ Added UI namespace for Text component
using UnityEngine.InputSystem; // ✅ Import the new Input System

public class EnergyShield : MonoBehaviour
{
    public Text scoreGT; // ✅ Score text UI reference
    public AudioSource audioSource; // ✅ Audio component reference

    void Start()
    {
        GameObject scoreGO = GameObject.Find("Score"); // ✅ Find the Score UI element
        if (scoreGO != null)
        {
            scoreGT = scoreGO.GetComponent<Text>();
            scoreGT.text = "0"; // ✅ Initialize score to 0
        }

        // ✅ Ensure AudioSource is assigned
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Mouse.current == null) return; // ✅ Prevents errors if no mouse is detected

        Vector2 mousePos2D = Mouse.current.position.ReadValue(); // ✅ Get mouse position using the new Input System
        mousePos2D.y = Mathf.Clamp(mousePos2D.y, 0, Screen.height); // ✅ Avoid potential issues with invalid Y values

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(new Vector3(mousePos2D.x, mousePos2D.y, -Camera.main.transform.position.z));

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject Collided = coll.gameObject;
        if (Collided.CompareTag("DragonEgg")) // ✅ Use CompareTag for better performance
        {
            Destroy(Collided);

            if (scoreGT != null) // ✅ Prevents errors if scoreGT is not assigned
            {
                int score = int.Parse(scoreGT.text); // ✅ Parse current score from UI
                score += 1; // ✅ Increase score
                scoreGT.text = score.ToString(); // ✅ Update score UI
            }

            // ✅ Play sound when collision occurs
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}
