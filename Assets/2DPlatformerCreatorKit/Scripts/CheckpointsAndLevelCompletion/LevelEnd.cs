using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class LevelEnd : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // Check if the other collider belongs to the player.
            if (collision.CompareTag("Player"))
            {
                CompleteLevel();
            }
        }

        /// <summary>
        /// Method to complete the level.
        /// </summary>
        private void CompleteLevel()
        {
            // Load the next level or show a level complete screen
            // Here, we simply load the next scene in the build order
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

            // Check if the next scene index is within the valid range
            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                // Load the next scene
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                // If there are no more scenes, go back to the main menu
                Debug.Log("No more levels! Returning to main menu.");
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}

