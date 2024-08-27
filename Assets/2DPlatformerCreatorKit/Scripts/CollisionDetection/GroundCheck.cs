/******************************************************************************
    Name: GroundCheck.cs
    Author: Logan Ryan
    Description: Checks if the player character has landed on a ground object.
******************************************************************************/
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    /// <summary>
    /// GroundCheck checks if the player character has landed on a ground object.
    /// </summary>
    public abstract class GroundCheck : MonoBehaviour
    {
        [SerializeField, Tooltip("Which layer(s) should be considered as ground.")]
        protected LayerMask groundLayer;
        [SerializeField, Tooltip("An empty GameObject positioned at the bottom of the player character.")]
        protected Transform groundCheck;
        [SerializeField, Tooltip("The radius of the circle used to check for ground contact.")]
        protected float groundCheckRadius = 0.2f;

        /// <summary>
        /// Is the player character touching a ground object?
        /// </summary>
        protected bool isGrounded;

        // Update is called once per frame
        protected virtual void Update()
        {
            CheckIfGrounded();
        }

        /// <summary>
        /// Checks if the groundCheck object is overlapping with any ground colliders.
        /// </summary>
        protected virtual void CheckIfGrounded()
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        }

        /// <summary>
        /// Returns the current value of 'isGrounded'.
        /// </summary>
        /// <returns></returns>
        public virtual bool IsGrounded()
        {
            return isGrounded;
        }
    }
}