using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class CollectibleItem : MonoBehaviour
    {
        [SerializeField, Tooltip("Value of the collectible in points.")]
        private int pointsValue = 10;
        [SerializeField, Tooltip("Value of the collectible in currency.")]
        private int currencyValue = 5;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            // Check if the player has collided with the collectible
            if (collision.CompareTag("Player"))
            {
                // Get the PlayerPoints script from the player object
                PlayerPoints playerPoints = collision.GetComponent<PlayerPoints>();

                if (playerPoints != null)
                {
                    // Add points and currency to the player
                    playerPoints.AddPoints(pointsValue);
                    playerPoints.AddCurrency(currencyValue);
                }

                // Destroy the collectible object after collision
                Destroy(gameObject);
            }
        }
    }
}