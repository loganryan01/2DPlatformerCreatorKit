/******************************************************************************
    Name: CeilingCheck.cs
    Author: Logan Ryan
    Description: Checks if the player character has touched a ceiling object.
******************************************************************************/
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    /// <summary>
    /// GroundCheck checks if the player character has landed on a ground object.
    /// </summary>
    public abstract class CeilingCheck : MonoBehaviour
    {
        [SerializeField, Tooltip("Which layer(s) should be considered as ground.")]
        protected LayerMask groundLayer;
        [SerializeField, Tooltip("An empty GameObject positioned at the top of the player character.")]
        protected Transform ceilingCheck;
        [SerializeField, Tooltip("The radius of the circle used to check for ground contact.")]
        protected float ceilingCheckRadius = 0.2f;

        protected bool isTouchingCeiling;

        // Update is called once per frame
        void Update()
        {
            CheckIfTouchingCeiling();
        }

        /// <summary>
        /// Checks if the ceilingCheck object is overlapping with any ground colliders.
        /// </summary>
        protected virtual void CheckIfTouchingCeiling()
        {
            isTouchingCeiling = Physics2D.OverlapCircle(ceilingCheck.position, ceilingCheckRadius, groundLayer);
        }

        /// <summary>
        /// Returns the current value of 'isTouchingCeiling'.
        /// </summary>
        /// <returns></returns>
        public virtual bool IsTouchingCeiling()
        {
            return isTouchingCeiling;
        }
    }
}