/******************************************************************************
    Name: MovingPlatform.cs
    Author: Logan Ryan
    Description: Moves platform horizontally or vertically.
******************************************************************************/
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    /// <summary>
    /// Moves platform horizontally or vertically.
    /// </summary>
    public abstract class MovingPlatform : MonoBehaviour
    {
        public enum MovementType { HORIZONTAL, VERTICAL }
        [SerializeField, Tooltip("Determines if the platform is moving horizontally or vertically.")]
        protected MovementType movementType;

        [SerializeField, Tooltip("Speed of the platform.")]
        protected float speed = 2.0f;
        [SerializeField, Tooltip("Distance the platform travels from its initial position.")]
        protected float distance = 5.0f;

        // Update is called once per frame
        protected virtual void Update()
        {
            MovePlatform();
        }

        /// <summary>
        /// Handles the movement logic.
        /// </summary>
        protected abstract void MovePlatform();
    }
}