/*****************************************************************************
    Name: PlayerJump.cs
    Author: Logan Ryan
    Description: Allows the player character to jump.
*****************************************************************************/
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    /// <summary>
    /// PlayerJump allows the player character to jump.
    /// </summary>
    public abstract class PlayerJump : MonoBehaviour
    {
        [SerializeField, Tooltip("The force applied to the player when jumping.")]
        protected float jumpForce = 10f;

        /// <summary>
        /// Make the player character jump.
        /// </summary>
        protected abstract void Jump();
    }
}

