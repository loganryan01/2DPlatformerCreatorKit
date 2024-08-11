using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField, Tooltip("The maximum health for the player.")]
        private int maximumHealth = 5;
        private int currentHealth;
        
        // Start is called before the first frame update
        void Start()
        {
            currentHealth = maximumHealth;
        }

        /// <summary>
        /// Method for player to take damage.
        /// </summary>
        /// <param name="amount"></param>
        public void TakeDamage(int amount)
        {
            currentHealth -= amount;

            if (currentHealth <= 0)
            {
                Kill();
            }
        }

        /// <summary>
        /// Method for when player dies.
        /// </summary>
        public void Kill()
        {
            Debug.Log("Player is dead!");
        }
    }
}