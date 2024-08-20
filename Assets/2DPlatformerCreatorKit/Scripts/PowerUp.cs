using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class PowerUp : MonoBehaviour
    {
        public enum PowerUpType { SpeedBoost }

        [SerializeField, Tooltip("The type of power-up.")]
        private PowerUpType powerUpType;
        [SerializeField, Tooltip("Duration of the power-up.")]
        private float powerUpDuration = 5f;

        private Renderer powerUpRenderer;
        private Collider2D powerUpCollider;

        private void Awake()
        {
            powerUpRenderer = GetComponent<Renderer>();
            powerUpCollider = GetComponent<Collider2D>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                PlayerPowerUp playerPowerUp = collision.GetComponent<PlayerPowerUp>();

                if (playerPowerUp != null)
                {
                    StartCoroutine(ApplyPowerUp(playerPowerUp));
                    powerUpRenderer.enabled = false;
                    powerUpCollider.enabled = false;
                }
            }
        }

        /// <summary>
        /// Coroutine to apply power up effect.
        /// </summary>
        /// <param name="playerPowerUp"></param>
        private IEnumerator ApplyPowerUp(PlayerPowerUp playerPowerUp)
        {
            // Apply power up based on type
            switch (powerUpType)
            {
                case PowerUpType.SpeedBoost:
                    playerPowerUp.StartSpeedBoost();
                    break;
            }

            // Wait for the duration of the power-up
            yield return new WaitForSeconds(powerUpDuration);

            // Revert the player's abilities after power-up expires
            switch (powerUpType)
            {
                case PowerUpType.SpeedBoost:
                    playerPowerUp.EndSpeedBoost();
                    break;
            }

            // Destroy the power-up object after use
            Destroy(gameObject);
        }
    }
}