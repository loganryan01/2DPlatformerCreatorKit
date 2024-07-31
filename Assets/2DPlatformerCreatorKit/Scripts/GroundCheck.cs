using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class GroundCheck : MonoBehaviour
    {
        [SerializeField, Tooltip("Which layer(s) should be considered as ground.")]
        private LayerMask groundLayer;
        [SerializeField, Tooltip("An empty GameObject positioned at the bottom of the player character.")]
        private Transform groundCheck;
        [SerializeField, Tooltip("The radius of the circle used to check for ground contact.")]
        private float groundCheckRadius = 0.2f;

        private bool isGrounded;

        // Update is called once per frame
        void Update()
        {
            CheckIfGrounded();
        }

        /// <summary>
        /// Checks if the groundCheck object is overlapping with any ground colliders.
        /// </summary>
        private void CheckIfGrounded()
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

            // For debug purposes, a ground check line is drawn in the scene view
            Debug.DrawLine(groundCheck.position, groundCheck.position + Vector3.down * groundCheckRadius, isGrounded ? Color.green : Color.red);
        }

        /// <summary>
        /// Returns the current value of 'isGrounded'.
        /// </summary>
        /// <returns></returns>
        public bool IsGrounded()
        {
            return isGrounded;
        }
    }
}

