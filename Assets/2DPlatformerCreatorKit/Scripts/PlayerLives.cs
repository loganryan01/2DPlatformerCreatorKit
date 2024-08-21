using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class PlayerLives : MonoBehaviour
    {
        [SerializeField, Tooltip("Maximum number of retries allowed.")]
        private int maxRetries = 3;

        private int currentRetries = 0; // Current number of retries used
        
        /// <summary>
        /// Method to call when the player fails. (e.g., falls off a platform)
        /// </summary>
        public void PlayerFailed()
        {
            if (currentRetries < maxRetries)
            {
                currentRetries++;
                RetryLevel();
            }
            else
            {
                GameOver();
            }
        }

        /// <summary>
        /// Method to reload the level for a retry.
        /// </summary>
        private void RetryLevel()
        {
            // Reload current scene to retry
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        /// <summary>
        /// Method to call when the player runs out of retries.
        /// </summary>
        private void GameOver()
        {
            Debug.Log("Game Over! No more retries left.");
        }
    }
}