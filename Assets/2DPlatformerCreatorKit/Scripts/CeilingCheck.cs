using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class CeilingCheck : MonoBehaviour
    {
        [SerializeField, Tooltip("Which layer(s) should be considered as ground.")]
        private LayerMask groundLayer;
        [SerializeField, Tooltip("An empty GameObject positioned at the top of the player character.")]
        private Transform ceilingCheck;
        [SerializeField, Tooltip("The radius of the circle used to check for ground contact.")]
        private float ceilingCheckRadius = 0.2f;

        private bool isTouchingCeiling;

        // Update is called once per frame
        void Update()
        {
            CheckIfTouchingCeiling();
        }

        /// <summary>
        /// Checks if the ceilingCheck object is overlapping with any ground colliders.
        /// </summary>
        private void CheckIfTouchingCeiling()
        {
            isTouchingCeiling = Physics2D.OverlapCircle(ceilingCheck.position, ceilingCheckRadius, groundLayer);

            // For debug purposes, a ground check line is drawn in the scene view
            Debug.DrawLine(ceilingCheck.position, ceilingCheck.position + Vector3.up * ceilingCheckRadius, isTouchingCeiling ? Color.green : Color.red);
        }

        /// <summary>
        /// Returns the current value of 'isTouchingCeiling'.
        /// </summary>
        /// <returns></returns>
        public bool IsTouchingCeiling()
        {
            return isTouchingCeiling;
        }
    }
}