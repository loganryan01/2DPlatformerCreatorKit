using UnityEngine;

using TwoDimensionalPlatformerCreatorKit;

namespace TwoDimensionalPlatformerDemo
{
    public class DemoCeilingCheck : CeilingCheck
    {
        /// <summary>
        /// Checks if the ceilingCheck object is overlapping with any ground colliders.
        /// </summary>
        protected override void CheckIfTouchingCeiling()
        {
            base.CheckIfTouchingCeiling();

            // For debug purposes, a ground check line is drawn in the scene view
            Debug.DrawLine(ceilingCheck.position, ceilingCheck.position + Vector3.up * ceilingCheckRadius, isTouchingCeiling ? Color.green : Color.red);
        }
    }
}

