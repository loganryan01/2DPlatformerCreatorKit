/*****************************************************************************
    Name: PlayerMove.cs
    Author: Logan Ryan
    Description: Implements left and right movement for the player character.
*****************************************************************************/
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    /// <summary>
    /// PlayerMove implements left and right movement for the player character.
    /// </summary>
    public abstract class PlayerMove : MonoBehaviour
    {
        [SerializeField, Tooltip("Determine how fast the object moves left or right.")]
        protected float moveSpeed = 5f;

        /// <summary>
        /// Stores the value of the virtual horizontal axis.
        /// </summary>
        protected float moveInput;

        protected virtual void Update()
        {
            moveInput = Input.GetAxis("Horizontal");
            
        }

        /// <summary>
        /// Move the player character left and right.
        /// </summary>
        protected abstract void Move();
    }
}

