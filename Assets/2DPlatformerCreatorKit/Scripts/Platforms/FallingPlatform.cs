using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class FallingPlatform : MonoBehaviour
    {
        [SerializeField, Tooltip("Time before the platform starts to fall.")]
        private float fallDelay = 1.0f;

        private Rigidbody2D rb;
        // Whether the player has triggered the fall
        private bool hasFallen = false;
        
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.isKinematic = true;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player") && !hasFallen) 
            {
                StartCoroutine(Fall());
            }
        }

        /// <summary>
        /// Make the platform fall.
        /// </summary>
        /// <returns></returns>
        private IEnumerator Fall()
        {
            hasFallen = true;

            yield return new WaitForSeconds(fallDelay);

            rb.isKinematic = false;
        }
    }
}