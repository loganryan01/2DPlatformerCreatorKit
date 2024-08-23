using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class Hazard : MonoBehaviour
    {
        [SerializeField, Tooltip("Amount of damage to inflict.")]
        private int damage = 1;
        [SerializeField, Tooltip("If true, kill the player instantly.")]
        private bool instantKill = false;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // Check if the object collided with is player
            if (collision.gameObject.CompareTag("Player"))
            {
                PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

                if (playerHealth != null)
                {
                    if (instantKill)
                    {
                        playerHealth.Kill();
                    }
                    else
                    {
                        playerHealth.TakeDamage(damage);
                    }
                }
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            // Check if the object collided with is player
            if (collision.gameObject.CompareTag("Player"))
            {
                PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

                if (playerHealth != null)
                {
                    if (instantKill)
                    {
                        playerHealth.Kill();
                    }
                    else
                    {
                        playerHealth.TakeDamage(damage);
                    }
                }
            }
        }
    }
}